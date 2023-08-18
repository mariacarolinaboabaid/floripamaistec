using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciosAPI.Context;
using Microsoft.AspNetCore.Mvc;

namespace exerciciosAPI.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class DetalheController : ControllerBase
    {
        private readonly ILogger<FichaController> _logger;
        private readonly FichaContext _fichaContext;


        public DetalheController(ILogger<FichaController> logger, FichaContext fichaCadastroDbContext)
        {
            _logger = logger;
            _fichaContext = fichaCadastroDbContext;
        }

    }
}