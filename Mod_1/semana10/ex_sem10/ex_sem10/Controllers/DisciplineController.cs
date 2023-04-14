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
    public class DisciplineController : ControllerBase
	{
        // Repository >>> dependency injection
        private readonly IDisciplineRepository _disciplineRepository;

        public DisciplineController(IDisciplineRepository disciplineRepository)
        {
            _disciplineRepository = disciplineRepository;

        }

        // Get all request
        [HttpGet]
        [Route("List-all")]
        public IActionResult GetAll()
        {
            var disciplines = _disciplineRepository.ObterLista();
            return Ok(disciplines);
        }

        // Get Id request
        [HttpGet]
        [Route("List-{id}")]
        public IActionResult GetId(int id)
        {

         
            var discipline = _disciplineRepository.ObterPorId(id);
            // If the id is inexistent 
            if (discipline == null)
            {
                return NotFound();
            }
            return Ok(discipline);
        }

        // Post request
        [HttpPost]
        [Route("Create")]
        // Gets from the body of the request the instance of the class Discipline
        public IActionResult Create([FromBody] DisciplineDto disciplineDto)
        {
            // Creating the object
            var discipline = new Discipline();
            discipline.Discipline_name = disciplineDto.Discipline_name;
            discipline.Teacher_id = disciplineDto.Teacher_id;
       
            _disciplineRepository.Adicionar(discipline);

            return CreatedAtAction(nameof(DisciplineController.GetId), new { id = discipline.Id }, disciplineDto);
        }

        // Put request
        [HttpPut]
        [Route("Update-{id}")]
        public IActionResult Update(int id, [FromBody] DisciplineDto disciplineDto)
        {

         
            var discipline = _disciplineRepository.ObterPorId(id);
            // If the id is inexistent 
            if (discipline == null)
            {
                return NotFound();
            }
            // Updating the data
            discipline.Discipline_name = disciplineDto.Discipline_name;
            discipline.Teacher_id = disciplineDto.Teacher_id;

            _disciplineRepository.Atualizar(discipline);

            return CreatedAtAction(nameof(DisciplineController.GetId), new { id = discipline.Id }, disciplineDto);
        }

        // Delete request
        [HttpDelete]
        [Route("Delete-{id}")]
        public IActionResult Delete(int id)
        {
            if (_disciplineRepository.Excluir(id))
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

