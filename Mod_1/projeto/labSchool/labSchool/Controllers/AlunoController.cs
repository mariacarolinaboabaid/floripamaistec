using System;
using labSchool.Dto;
using labSchool.Models;
using labSchool.Repositories.Interfaces;
using labSchool.Repository;
using Microsoft.AspNetCore.Mvc;


namespace labSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
	{

        // Injeção de dependência do Repositório
        private readonly IAlunoRepository _alunoRepository;
    
        public AlunoController(IAlunoRepository alunoRepository)
        {
            _alunoRepository  = alunoRepository;
        }



        // RETORNA O OBJETO ALUNO PELO ID
        public IActionResult ObterPorCodigo(int id)
        {

            // Capturing the answer
            var aluno = _alunoRepository.ObterPorCodigo(id);
            // If the id is inexistent 

            return Ok(aluno);

        }

            // ADICIONAR
        [HttpPost]
        [Route("api/alunos")]
        public IActionResult Adicionar([FromBody] AlunoAdicionarDto alunoDto)
        {
            // Verificando se os dados informados atendem os requisitos
            if (ModelState.IsValid == false)
            {
                return StatusCode(StatusCodes.Status400BadRequest, ModelState);
            }

            // Se sim, criando a nova instância de aluno
            var aluno = new Aluno();
            aluno.Nome = alunoDto.Nome;
            aluno.Telefone = alunoDto.Telefone;
            aluno.DataNascimento = alunoDto.DataNascimento;
            aluno.Cpf = alunoDto.Cpf;
            aluno.SituacaoMatricula = alunoDto.SituacaoMatricula;
            aluno.NotaProcessoSeletivo = alunoDto.NotaProcessoSeletivo;

            // Commitando no BD
            _alunoRepository.Adicionar(aluno);


            // Saída DTO
            var alunoCriado = new AlunoCriadoSaidaDto();
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

