using System;
using labSchool.Dto;
using labSchool.Models;
using labSchool.Repositories;
using labSchool.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace labSchool.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
	{
        // INJEÇÃO DE DEPENDÊNCIA DO REPOSITÓRIO
        private readonly IProfessorRepository _professorRepository;

        public ProfessorController(IProfessorRepository professorRepository)
        {
            _professorRepository = professorRepository;
        }


        // OBTER LISTA COMPLETA DE PROFESSORES
        [HttpGet]
        [Route("api/professores")]
        public IActionResult Obter()
        {
            var professores = _professorRepository.Obter();

            if (professores.Count() == 0)
            {
                return NotFound("No banco de dados não há nenhum registro de professor.");
            }
            else
            {
                List<ProfessorSaidaDto> professoresDtoSaida = new List<ProfessorSaidaDto>();
                foreach (var professor in professores)
                {
                    var professorSaida = new ProfessorSaidaDto();
                    professorSaida.Codigo = professor.Codigo;
                    professorSaida.Nome = professor.Nome;
                    professorSaida.Telefone = professor.Telefone;
                    professorSaida.DataNascimento = professor.DataNascimento;
                    professorSaida.Cpf = professor.Cpf;
                    professorSaida.FormacaoAcademica = professor.FormacaoAcademica;
                    professorSaida.Experiencia = professor.Experiencia;
                    professorSaida.Estado = professor.Estado;

                    professoresDtoSaida.Add(professorSaida);
                }
                return Ok(professoresDtoSaida);
            }
        }
    }
}

