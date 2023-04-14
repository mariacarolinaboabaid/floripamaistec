using System;
using ex_sem10.Context;
using ex_sem10.Models;
using ex_sem10.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;
using ex_sem10.Repositories.Interfaces;

namespace ex_sem10.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AnswerController : ControllerBase
	{
        // Repository >>> dependency injection
        private readonly IAnswerRepository _answerRepository;

        public AnswerController(IAnswerRepository answerRepository)
		{
            _answerRepository = answerRepository;

        }

        // Get all request
        [HttpGet]
		[Route("List-all")]
		public IActionResult GetAll()
		{
            var answers = _answerRepository.ObterLista();
            return Ok(answers);
		}

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {
           
            // Capturing the answer
            var answer = _answerRepository.ObterPorId(id);
            // If the id is inexistent 
            if (answer == null)
            {
                return NotFound();
            }
            return Ok(answer);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
		// Gets from the body of the request the instance of the class Answer
        public IActionResult Create([FromBody] AnswerCreateDto answerDto)
        {
            // Creating the object
            var answer = new Answer();
            answer.Response = answerDto.Response;
            answer.Score = answerDto.Score;
            answer.Observation = answerDto.Observation;
            answer.Student_id = answerDto.Student_id;
            answer.Question_id = answerDto.Question_id;

            _answerRepository.Adicionar(answer);

            return CreatedAtAction(nameof(AnswerController.GetId), new { id = answer.Id }, answerDto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] AnswerUpdateDto answerDto)
        {

            // Capturing the answer
            var answer = _answerRepository.ObterPorId(id);
            // If the id is inexistent 
            if (answer == null)
            {
                return NotFound();
            }
            // Updating the data
            answer.Score = answerDto.Score;
            answer.Observation = answerDto.Observation;

            _answerRepository.Atualizar(answer);

            return CreatedAtAction(nameof(AnswerController.GetId), new { id = answer.Id }, answer);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        { 
            // If the id is inexistent 
            if( _answerRepository.Excluir(id))
            {
                return NoContent(); 
            }
            else
            {
                return NotFound();
            }
            
        }
    }
}

