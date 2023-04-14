using System;
using ex_sem10.Dto;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ex_sem10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
	{
        // Repository >>> dependency injection
        private readonly IQuizRepository _quizRepository;

        public QuizController(IQuizRepository quizRepository)
        {
            _quizRepository = quizRepository;

        }

        // Get all request
        [HttpGet]
        [Route("List-all")]
        public IActionResult GetAll()
        {
            var quizzes = _quizRepository.ObterLista();
            return Ok(quizzes);
        }

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {

            // Capturing the teacher
            var quiz = _quizRepository.ObterPorId(id);
            // If the id is inexistent 
            if (quiz == null)
            {
                return NotFound();
            }
            return Ok(quiz);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
        // Gets from the body of the request the instance of the class 
        public IActionResult Create([FromBody] QuizCreateDto quizDto)
        {
            // Creating the object
            var quiz = new Quiz();
            quiz.Title = quizDto.Title;
            quiz.Date_open = quizDto.Date_open;
            quiz.Date_close = quizDto.Date_close;
            quiz.Discipline_id = quizDto.Discipline_id;

            _quizRepository.Adicionar(quiz);

            return CreatedAtAction(nameof(QuizController.GetId), new { id = quiz.Id }, quizDto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] QuizUpdateDto quizDto)
        {
            var quiz = _quizRepository.ObterPorId(id);
            // If the id is inexistent 
            if (quiz == null)
            {
                return NotFound();
            }
            // Updating the data
            quiz.Title = quizDto.Title;
            quiz.Date_open = quizDto.Date_open;
            quiz.Date_close = quizDto.Date_close; 


            _quizRepository.Atualizar(quiz);

            return CreatedAtAction(nameof(QuizController.GetId), new { id = quiz.Id }, quizDto);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        {
            // If the id is inexistent 
            if (_quizRepository.Excluir(id))
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

