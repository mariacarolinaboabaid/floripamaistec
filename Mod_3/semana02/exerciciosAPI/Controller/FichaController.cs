using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using exerciciosAPI.DTO.Ficha;
using exerciciosAPI.Models;
using exerciciosAPI.Context;
using System.Net;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;

namespace exerciciosAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class FichaController : ControllerBase
    {
        private readonly ILogger<FichaController> _logger;
        private readonly FichaContext _fichaContext;
        private readonly IMapper _mapper;


        public FichaController(ILogger<FichaController> logger, FichaContext fichaContext, IMapper mapper)
        {
            _logger = logger;
            _fichaContext = fichaContext;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FichaReadDTO> Post([FromBody] FichaCreateDTO fichaCreateDTO)
        {
            try
            {
                var fichaModel = _mapper.Map<FichaModel>(fichaCreateDTO);

                if (_fichaContext.FichaModels.ToList().Exists(e => e.Email == fichaCreateDTO.EmailInformado))
                {
                    return Conflict(new { erro = "E-mail Cadastrado" });
                }

                _fichaContext.FichaModels.Add(fichaModel);
                _fichaContext.SaveChanges();


                var fichaReadDTO = _mapper.Map<FichaReadDTO>(fichaModel);

                return StatusCode(HttpStatusCode.Created.GetHashCode(), fichaReadDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(HttpStatusCode.InternalServerError.GetHashCode(), ex);
            }

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<FichaReadDTO>> Get([FromQuery] string? email)
        {
            try
            {
                List<FichaModel> fichaModels;

                if (email.IsNullOrEmpty())
                {
                    fichaModels = _fichaContext.FichaModels
                                                         .Include(i => i.Detalhes)
                                                         .ToList();
                }
                else
                {
                    fichaModels = _fichaContext.FichaModels
                                                         .Where(w => w.Email.Equals(email!))
                                                         .Include(i => i.Detalhes).ToList();
                }

                var fichaReadDTO = _mapper.Map<List<FichaReadDTO>>(fichaModels);
                return Ok(fichaReadDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FichaReadDTO> Get(int id)
        {
            try
            {
                var fichaModel = _fichaContext.FichaModels.Find(id);

                if (fichaModel == null)
                {
                    return NotFound(new { erro = "Ficha n�o encontrada" });
                }

                var fichaReadDTO = _mapper.Map<FichaReadDTO>(fichaModel);
                return Ok(fichaReadDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(HttpStatusCode.InternalServerError.GetHashCode(), ex);
            }
        }


        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<FichaReadDTO> Put(int id, [FromBody] FichaUpdateDTO fichaUpdateDTO)
        {
            try
            {
                var fichaModel = _fichaContext.FichaModels.Where(w => w.Id == id).FirstOrDefault();

                if (fichaModel == null)
                {
                    return NotFound(new { erro = "Registro n�o encontrado" });
                }

                fichaModel = _mapper.Map(fichaUpdateDTO, fichaModel);

                _fichaContext.FichaModels.Update(fichaModel);
                _fichaContext.SaveChanges();
                var fichaReadDTO = _mapper.Map<FichaReadDTO>(fichaModel);

                return Ok(fichaReadDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Delete(int id)
        {
            try
            {
                var fichaModel = _fichaContext.FichaModels.Where(w => w.Id == id).FirstOrDefault();

                if (fichaModel == null)
                {
                    return NotFound(new { erro = "Registro n�o encontrado" });
                }

                if (fichaModel.Detalhes != null && fichaModel.Detalhes!.Count > 0)
                {
                    return NotFound(new { erro = "Existe Detalhes relacionados com a ficha" });
                }

                _fichaContext.FichaModels.Remove(fichaModel);
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
