using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using exerciciosAPI.Context;
using exerciciosAPI.DTO.Telefone;
using exerciciosAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace exerciciosAPI.Controller
{
    [ApiController]
    [Route("api/controller")]
    public class TelefoneController : ControllerBase
    {
        private readonly ILogger<FichaController> _logger;
        private readonly FichaContext _fichaContext;
        private readonly IMapper _mapper;


        public TelefoneController(ILogger<FichaController> logger, FichaContext fichaContext, IMapper mapper)
        {
            _logger = logger;
            _fichaContext = fichaContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<TelefoneReadDTO>> GetAllOrByDDD([FromQuery] string? ddd)
        {
            try
            {
                List<TelefoneModel> listaTelefones;

                if (string.IsNullOrEmpty(ddd))
                {
                    listaTelefones = _fichaContext.TelefoneModels.ToList();
                }
                else
                {
                    listaTelefones = _fichaContext.TelefoneModels.Where(item => item.DDD.Equals(ddd)).ToList();
                }

                if (listaTelefones.Count() == 0)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var listaTelefonesRead = _mapper.Map<List<TelefoneReadDTO>>(listaTelefones);

                return Ok(listaTelefonesRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<TelefoneReadDTO> GetById(int id)
        {
            try
            {
                var telefone = _fichaContext.TelefoneModels.Find(id);

                if (telefone == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var telefoneRead = _mapper.Map<TelefoneReadDTO>(telefone);
                return Ok(telefoneRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<TelefoneReadDTO> Post([FromBody] TelefoneCreateDTO telefoneCreateDTO)
        {
            try 
            {
                if (_fichaContext.TelefoneModels.ToList().Exists(item => item.DDD == telefoneCreateDTO.DDD && item.Numero == telefoneCreateDTO.Numero))
                {
                    return Conflict("Número já cadastrado!");
                }

                var novoTelefone = _mapper.Map<TelefoneModel>(telefoneCreateDTO);

                _fichaContext.TelefoneModels.Add(novoTelefone);
                _fichaContext.SaveChanges();

                var novoTelefoneRead = _mapper.Map<TelefoneReadDTO>(novoTelefone);

                return StatusCode(HttpStatusCode.Created.GetHashCode(), novoTelefoneRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }    

        [HttpPut]
        public ActionResult<TelefoneReadDTO> Put(int id, [FromBody] TelefoneUpdateDTO telefoneUpdateDTO)
        {
            try 
            {
                var telefoneAtualizado = _fichaContext.TelefoneModels.Where(item => item.Id == id).FirstOrDefault();

                if (telefoneAtualizado == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                telefoneAtualizado = _mapper.Map(telefoneUpdateDTO, telefoneAtualizado);
                _fichaContext.TelefoneModels.Update(telefoneAtualizado);
                _fichaContext.SaveChanges();
                
                var telefoneAtualizadoRead = _mapper.Map<TelefoneReadDTO>(telefoneAtualizado);
                return Ok(telefoneAtualizadoRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }           
        }

        [HttpDelete]
        public ActionResult Delete (int id)
        {
             try
            {
                var telefone = _fichaContext.TelefoneModels.Find(id);

                if (telefone == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                _fichaContext.TelefoneModels.Remove(telefone);
                _fichaContext.SaveChanges();
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}