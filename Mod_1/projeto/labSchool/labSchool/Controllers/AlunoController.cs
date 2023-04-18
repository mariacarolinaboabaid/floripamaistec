using System;
using labSchool.Dto;
using labSchool.Models;
using labSchool.Repositories.Interfaces;
using labSchool.Repositories;
using Microsoft.AspNetCore.Mvc;
using labSchool.Validators;
using Microsoft.EntityFrameworkCore;


namespace labSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
	{
        // INJEÇÃO DE DEPENDÊNCIA DO REPOSITÓRIO
        private readonly IAlunoRepository _alunoRepository;
    
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository  = alunoRepository;
        }

        // LISTAR ALUNOS COM PARÂMETRO SITUAÇÃO DA MATRÍCULA COMO OPCIONAL
        [HttpGet]
        [Route("api/alunos")]
        public IActionResult Obter(string? situacao)
        {
            // CASO O VALOR DA SITUAÇÃO SEJA NÃO VÁLIDO
            if (!string.IsNullOrEmpty(situacao) && (situacao != "ATIVO" && situacao != "IRREGULAR" && situacao != "ATENDIMENTO"
                && situacao != "ATENDIMENTO_PEDAGOGICO" && situacao != "INATIVO"))
            {
                return BadRequest("O valor do parâmetro informado não é válido." +
                    " Os valores válidos são: 'ATIVO', 'IRREGULAR', 'ATENDIMENTO_PEDAGOGICO', 'INATIVO'.");
            }

            
            var resposta = _alunoRepository.Obter(situacao);

            // CASO NÃO TENHA NENHUM REGISTRO DE RETORNO DO BANCO DE DADOS
            if (resposta.Count() == 0)
            {
                return NotFound("No banco de dados não há nenhum aluno com a situação de matrícula informada.");
            }
            else
            {
                List<AlunoSaidaDto> alunosDtoSaida = new List<AlunoSaidaDto>();
                foreach (var aluno in resposta)
                {
                    var alunoSaida = new AlunoSaidaDto();
                    alunoSaida.Codigo = aluno.Codigo;
                    alunoSaida.Nome = aluno.Nome;
                    alunoSaida.Telefone = aluno.Telefone;
                    alunoSaida.DataNascimento = aluno.DataNascimento;
                    alunoSaida.Cpf = aluno.Cpf;
                    alunoSaida.SituacaoMatricula = aluno.SituacaoMatricula;
                    alunoSaida.NotaProcessoSeletivo = aluno.NotaProcessoSeletivo;
                    alunoSaida.TotalAtendimentosPedagogicos = aluno.TotalAtendimentosPedagogicos;

                    alunosDtoSaida.Add(alunoSaida);
                }
                return Ok(alunosDtoSaida);
            }  
        }

        // LISTAR ALUNO PELO CÓDIGO IDENTIFICADOR
        [HttpGet]
        [Route("api/alunos/{codigo}")]
        public IActionResult ObterPorCodigo(int codigo)
        {
            var aluno = _alunoRepository.ObterPorCodigo(codigo);
            if (aluno == null)
            {
                return NotFound("O CÓDIGO DO ALUNO informado não existe no banco de dados.");
            }

            // SAÍDA DTO
            var alunoSaida = new AlunoSaidaDto();
            alunoSaida.Codigo = aluno.Codigo;
            alunoSaida.Nome = aluno.Nome;
            alunoSaida.Telefone = aluno.Telefone;
            alunoSaida.DataNascimento = aluno.DataNascimento;
            alunoSaida.Cpf = aluno.Cpf;
            alunoSaida.SituacaoMatricula = aluno.SituacaoMatricula;
            alunoSaida.NotaProcessoSeletivo = aluno.NotaProcessoSeletivo;
            alunoSaida.TotalAtendimentosPedagogicos = aluno.TotalAtendimentosPedagogicos;

            return Ok(alunoSaida);
        }

        // EXCLUSÃO DE ALUNO PELO CÓDIGO IDENTIFICADOR
        [HttpDelete]
        [Route("api/alunos/{codigo}")]
        public IActionResult Excluir(int codigo)
        {
            if (_alunoRepository.Delete(codigo))
            {
                return NoContent();
            }
            else
            {
                return NotFound("O CÓDIGO DO ALUNO informado não existe no banco de dados.");
            }
        }

        // ATUALIZAÇÃO DA SITUAÇÃO DA MATRÍCULA DO ALUNO
        [HttpPut]
        [Route("api/alunos/{codigo}")]
        public IActionResult Atualizar(int codigo, [FromBody] AlunoAtualizarSituacaoDto alunoDto)
        {
            var aluno = _alunoRepository.ObterPorCodigo(codigo);
            
            if (aluno == null)
            {
                return NotFound("O CÓDIGO DO ALUNO informado não existe no banco de dados.");
            }

            aluno.SituacaoMatricula = alunoDto.SituacaoMatricula;

            var alunoValidator = new AlunoValidator();
            var validatorResult = alunoValidator.Validate(aluno);

            if (validatorResult.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult.Errors);
            }

            _alunoRepository.Atualizar(aluno);

            // SAÍDA DTO
            var alunoSaida = new AlunoSaidaDto();
            alunoSaida.Codigo = aluno.Codigo;
            alunoSaida.Nome = aluno.Nome;
            alunoSaida.Telefone = aluno.Telefone;
            alunoSaida.DataNascimento = aluno.DataNascimento;
            alunoSaida.Cpf = aluno.Cpf;
            alunoSaida.SituacaoMatricula = aluno.SituacaoMatricula;
            alunoSaida.NotaProcessoSeletivo = aluno.NotaProcessoSeletivo;
            alunoSaida.TotalAtendimentosPedagogicos = aluno.TotalAtendimentosPedagogicos;

            return Ok(alunoSaida);
        }

        // ADICIONAR
        [HttpPost]
        [Route("api/alunos")]
        public IActionResult Adicionar([FromBody] AlunoAdicionarDto alunoDto)
        {
            var aluno = new Aluno();
            aluno.Nome = alunoDto.Nome;
            aluno.Telefone = alunoDto.Telefone;
            aluno.DataNascimento = alunoDto.DataNascimento;
            aluno.Cpf = alunoDto.Cpf;
            aluno.SituacaoMatricula = alunoDto.SituacaoMatricula;
            aluno.NotaProcessoSeletivo = alunoDto.NotaProcessoSeletivo;

            var alunoValidator = new AlunoValidator();
            var validatorResult = alunoValidator.Validate(aluno);

            if (validatorResult.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validatorResult.Errors);
            }

            if (_alunoRepository.CPF_Unico(aluno.Cpf) == false)
            {
                return Conflict("O campo CPF informado já existe.");
            }

            _alunoRepository.Adicionar(aluno);

            // SAÍDA DTO
            var alunoCriado = new AlunoSaidaDto();
            alunoCriado.Codigo = aluno.Codigo;
            alunoCriado.Nome = aluno.Nome;
            alunoCriado.Telefone = aluno.Telefone;
            alunoCriado.DataNascimento = aluno.DataNascimento;
            alunoCriado.Cpf = aluno.Cpf;
            alunoCriado.SituacaoMatricula = aluno.SituacaoMatricula;
            alunoCriado.NotaProcessoSeletivo = aluno.NotaProcessoSeletivo;
            alunoCriado.TotalAtendimentosPedagogicos = aluno.TotalAtendimentosPedagogicos;

           return CreatedAtAction(nameof(AlunoController.ObterPorCodigo), new { codigo = aluno.Codigo }, alunoCriado) ;
        }
    }

   
}

