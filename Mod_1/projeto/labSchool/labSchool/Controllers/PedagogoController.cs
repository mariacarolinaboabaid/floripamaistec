using System;
using labSchool.Dto;
using labSchool.Models;
using labSchool.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace labSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedagogoController : ControllerBase
    {
        // INJEÇÃO DE DEPENDÊNCIA DO REPOSITÓRIO
        private readonly IPedagogoRepository _pedagogoRepository;

        public PedagogoController(IPedagogoRepository pedagogoRepository)
        {
            _pedagogoRepository = pedagogoRepository;
        }

        // OBTER LISTA COMPLETA DE PEDAGOGOS
        [HttpGet]
        [Route("api/pedagogos")]
        public IActionResult Obter()
        {
            var pedagogos = _pedagogoRepository.Obter();

            if (pedagogos.Count() == 0)
            {
                return NotFound("No banco de dados não há nenhum registro de pedagogo.");
            }
            else
            {
                List<PedagogoSaidaDto> pedagogosDtoSaida = new List<PedagogoSaidaDto>();
                foreach (var pedagogo in pedagogos)
                {
                    var pedagogoSaida = new PedagogoSaidaDto();
                    pedagogoSaida.Codigo = pedagogo.Codigo;
                    pedagogoSaida.Nome = pedagogo.Nome;
                    pedagogoSaida.Telefone = pedagogo.Telefone;
                    pedagogoSaida.DataNascimento = pedagogo.DataNascimento;
                    pedagogoSaida.Cpf = pedagogo.Cpf;
                    pedagogoSaida.TotalAtendimentosPedagogicos = pedagogo.TotalAtendimentosPedagogicos;

                    pedagogosDtoSaida.Add(pedagogoSaida);
                }
                return Ok(pedagogosDtoSaida);
            }

        }
    }
}

