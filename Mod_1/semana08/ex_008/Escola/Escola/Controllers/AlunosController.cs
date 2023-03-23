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
	}
}

