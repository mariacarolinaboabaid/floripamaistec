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
    public class TeacherController : ControllerBase
    {
        // Repository >>> dependency injection
        private readonly ITeacherRepository _teacherRepository;

        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;

        }

        // Get all request
        [HttpGet]
        [Route("List-all")]
        public IActionResult GetAll()
        {
            var teachers = _teacherRepository.ObterLista();
            return Ok(teachers);
        }

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {

            // Capturing the teacher
            var teacher = _teacherRepository.ObterPorId(id);
            // If the id is inexistent 
            if (teacher == null)
            {
                return NotFound();
            }
            return Ok(teacher);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
        // Gets from the body of the request the instance of the class Teacher
        public IActionResult Create([FromBody] CreateTeacherDto teacherDto)
        {
            // Creating the object
            var teacher = new Teacher();
            teacher.Departament = teacherDto.Departament;
            teacher.User_id = teacherDto.User_id; 

            _teacherRepository.Adicionar(teacher);

            return CreatedAtAction(nameof(TeacherController.GetId), new { id = teacher.Id }, teacherDto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] UpdateTeacherDto teacherDto)
        {
            var teacher = _teacherRepository.ObterPorId(id);
            // If the id is inexistent 
            if (teacher == null)
            {
                return NotFound();
            }
            // Updating the data
            teacher.Departament = teacherDto.Departament;
       

            _teacherRepository.Atualizar(teacher);

            return CreatedAtAction(nameof(TeacherController.GetId), new { id = teacher.Id }, teacherDto);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        {
            // If the id is inexistent 
            if (_teacherRepository.Excluir(id))
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

