using System;
using Microsoft.AspNetCore.Mvc;
using Escola.Models;
using Escola.Repositories;

namespace Escola.Controllers
{

	[ApiController]
	[Route("[controller]")]
	public class AlunosController : ControllerBase
	{
		// Método para listar todos os alunos
		[HttpGet]
		[Route("listar-alunos")]
		public IActionResult ListarAlunos(string? nome)
		{
			var repository = new AlunosRepository();
			var alunos = repository.ListarAlunosRepository(nome);
            return Ok(alunos);
		}

        // Método para obter aluno por ID
        [HttpGet]
        [Route("obter-aluno-por-{id}")]
        public IActionResult ObterPorID(int id)
        {
            var repository = new AlunosRepository();
            var aluno = repository.ObterAlunoPorID(id);
            // Resposta Error 400
            if (id <= 0)
            {
                return BadRequest("ID deve ser maior que 0.");
            }
            // Caso o ID não seja encontrado
            if (aluno == null)
            {
                return NotFound();
            }
            // Resposta Success 200
            return Ok(aluno);
        }
    }
}

