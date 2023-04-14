using System;
using ex_sem10.Dto;
using ex_sem10.Models;
using ex_sem10.Repositories;
using ex_sem10.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyModel;

namespace ex_sem10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentDisciplineController : ControllerBase
    {
		// Repository >>> dependency injection
        private readonly IStudentDisciplineRepository _studentDisciplineRepository;

        public StudentDisciplineController(IStudentDisciplineRepository studentDisciplineRepository)
        {
            _studentDisciplineRepository = studentDisciplineRepository;

        }

        // Get all request
        [HttpGet]
        [Route("List-all")]
        public IActionResult GetAll()
        {
            var students_disciplines = _studentDisciplineRepository.ObterLista();
            return Ok(students_disciplines);
        }

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {


            var student_discipline = _studentDisciplineRepository.ObterPorId(id);
            // If the id is inexistent 
            if (student_discipline == null)
            {
                return NotFound();
            }
            return Ok(student_discipline);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
        // Gets from the body of the request the instance of the class 
        public IActionResult Create([FromBody] StudentDisciplineDto sd_Dto)
        {
            // Creating the object
            var student_discipline = new StudentDiscipline();
            student_discipline.Student_id = sd_Dto.Student_id;
            student_discipline.Discipline_id = sd_Dto.Discipline_id;


            _studentDisciplineRepository.Adicionar(student_discipline);

            return CreatedAtAction(nameof(StudentDisciplineController.GetId), new { id = student_discipline.Id }, sd_Dto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] StudentDisciplineDto sd_Dto)
        {


            var student_discipline = _studentDisciplineRepository.ObterPorId(id);
            // If the id is inexistent 
            if (student_discipline == null)
            {
                return NotFound();
            }
            // Updating the data
            student_discipline.Student_id = sd_Dto.Student_id;
            student_discipline.Discipline_id = sd_Dto.Discipline_id;

            _studentDisciplineRepository.Atualizar(student_discipline);

            return CreatedAtAction(nameof(StudentDisciplineController.GetId), new { id = student_discipline.Id }, sd_Dto);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        {
            if (_studentDisciplineRepository.Excluir(id))
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

