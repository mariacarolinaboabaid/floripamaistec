using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using exerciciosAPI.Context;
using exerciciosAPI.Models;
using exerciciosAPI.SingleResponsabilityPrinciple;
using Microsoft.AspNetCore.Mvc;

namespace exerciciosAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetalheController : ControllerBase
    {
        private readonly ILogger<FichaController> _logger;
        private readonly FichaContext _fichaContext;
         private readonly IMapper _mapper;


        public DetalheController(ILogger<FichaController> logger, FichaContext fichaCadastroDbContext, IMapper mapper)
        {
            _logger = logger;
            _fichaContext = fichaCadastroDbContext;
            _mapper =  mapper;
        }

        [HttpGet("UnificarDadosSRP")]
        public ActionResult Get()
        {
            try
            {
                List<DetalheModel> listaDetalhes;

                listaDetalhes = _fichaContext.DetalheModels.ToList();

                if (listaDetalhes.Count() == 0)
                {
                    return NotFound("Nenhum registro existente!");
                }
                
                UnificarDadosSRP unificar = new UnificarDadosSRP(listaDetalhes);
                unificar.Resultado();

                return Ok(unificar);
              
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }

    }
}