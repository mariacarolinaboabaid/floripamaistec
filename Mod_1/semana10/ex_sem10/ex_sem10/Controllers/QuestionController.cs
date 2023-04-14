using System;
using ex_sem10.Dto;
using ex_sem10.Models;
using ex_sem10.Repositories;
using ex_sem10.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ex_sem10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionController : ControllerBase
	{
        // Repository >>> dependency injection
        private readonly IQuestionRepository _questionRepository;

        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;

        }

        // Get all request
        [HttpGet]
        [Route("List-all")]
        public IActionResult GetAll()
        {
            var questions = _questionRepository.ObterLista();
            return Ok(questions);
        }

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {

            var question = _questionRepository.ObterPorId(id);
            // If the id is inexistent 
            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
        // Gets from the body of the request the instance of the class Question
        public IActionResult Create([FromBody] QuestionDto questionDto)
        {
            // Creating the object
            var question = new Question();
            question.Enunciation = questionDto.Enunciation;
            question.Weight = questionDto.Weight;
            question.Quiz_id = questionDto.Quiz_id;

            _questionRepository.Adicionar(question);

            return CreatedAtAction(nameof(QuestionController.GetId), new { id = question.Id }, questionDto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] QuestionDto questionDto)
        {

            // Capturing the answer
            var question = _questionRepository.ObterPorId(id);
            // If the id is inexistent 
            if (question == null)
            {
                return NotFound();
            }
            // Updating the data
            question.Enunciation = questionDto.Enunciation;
            question.Weight = questionDto.Weight;
            question.Quiz_id = questionDto.Quiz_id; ;

            _questionRepository.Atualizar(question);

            return CreatedAtAction(nameof(QuestionController.GetId), new { id = question.Id }, questionDto);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        {
            // If the id is inexistent 
            if (_questionRepository.Excluir(id))
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

