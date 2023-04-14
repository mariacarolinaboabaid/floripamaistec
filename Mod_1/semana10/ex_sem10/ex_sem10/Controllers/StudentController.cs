using System;
using ex_sem10.Dto;
using ex_sem10.Models;
using ex_sem10.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ex_sem10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
	{
        // Repository >>> dependency injection
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }

        // Get all request
        [HttpGet]
        [Route("List-all")]
        public IActionResult GetAll()
        {
            var students = _studentRepository.ObterLista();
            return Ok(students);
        }

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {


            var student = _studentRepository.ObterPorId(id);
            // If the id is inexistent 
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
        // Gets from the body of the request the instance of the class 
        public IActionResult Create([FromBody] StudentCreateDto studentDto)
        {
            // Creating the object
            var student = new Student();
            student.Periodo= studentDto.Periodo;
            student.Ra = studentDto.Ra;
            student.User_id= studentDto.User_id;

            _studentRepository.Adicionar(student);

            return CreatedAtAction(nameof(StudentController.GetId), new { id = student.Id }, studentDto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] StudentUpateDto studentDto)
        {


            var student = _studentRepository.ObterPorId(id);
            // If the id is inexistent 
            if (student == null)
            {
                return NotFound();
            }
            // Updating the data
            student.Periodo = studentDto.Periodo;
            student.Ra = studentDto.Ra;

            _studentRepository.Atualizar(student);

            return CreatedAtAction(nameof(StudentController.GetId), new { id = student.Id }, studentDto);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        {
            if (_studentRepository.Excluir(id))
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

