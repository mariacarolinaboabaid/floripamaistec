using System;
using System.ComponentModel.DataAnnotations;
using labSchool.Context;
using labSchool.Dto;
using labSchool.Repositories;
using labSchool.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace labSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AtendimentoController : ControllerBase
    {

        // INJEÇÃO DE DEPENDÊNCIA DO REPOSITÓRIO
        private readonly IAtendimentoRepository _atendimentoRepository;

        public AtendimentoController(IAtendimentoRepository atendimentoRepository)
        {
            _atendimentoRepository = atendimentoRepository;
        }

        // ATUALIZAR ATENDIMENTOS DE ALUNO E PEDAGOGO
        [HttpPut]
        [Route("api/-/atendimentos")]
        public IActionResult Atualizar([FromBody] AtendimentoEntradaDto atendimentoDto)
        {

            var aluno = _atendimentoRepository.ObterPorCodigoAluno(atendimentoDto.CodigoAluno);
            var pedagogo = _atendimentoRepository.ObterPorCodigoPedagogo(atendimentoDto.CodigoPedagogo);

            if (aluno == null)
            {
                return NotFound("O CÓDIGO DO ALUNO informado não existe no banco de dados.");
            }
            else if (pedagogo == null)
            {
                return NotFound("O CÓDIGO DO PEDAGOGO informado não existe no banco de dados.");
            }

            aluno.AdicionarAtendimento();
            pedagogo.AdicionarAtendimento();
            _atendimentoRepository.AtualizarAluno(aluno);
            _atendimentoRepository.AtualizarPedagogo(pedagogo);

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

            var pedagogoSaida = new PedagogoSaidaDto();
            pedagogoSaida.Codigo = pedagogo.Codigo;
            pedagogoSaida.Nome = pedagogo.Nome;
            pedagogoSaida.Telefone = pedagogo.Telefone;
            pedagogoSaida.DataNascimento = pedagogo.DataNascimento;
            pedagogoSaida.Cpf = pedagogo.Cpf;
            pedagogoSaida.TotalAtendimentosPedagogicos = pedagogo.TotalAtendimentosPedagogicos;

            return Ok(new {alunoSaida, pedagogoSaida});
        }
    }

   
}

