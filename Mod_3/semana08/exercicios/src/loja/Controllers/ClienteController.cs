using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using loja.Context;
using loja.Dto.Cliente;
using loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace loja.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ClienteController : ControllerBase
    {

        private readonly LojaContext _lojaContext;
        private readonly IMapper _mapper;


        public ClienteController(LojaContext lojaContext, IMapper mapper)
        {
            _lojaContext = lojaContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ClienteReadDTO>> GetAll()
        {
            try
            {
                List<ClienteModel> listaClientes;

                listaClientes= _lojaContext.Clientes.ToList();

                if (listaClientes.Count() == 0)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var listaClientesRead = _mapper.Map<List<ClienteReadDTO>>(listaClientes);

                return Ok(listaClientesRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<ClienteReadDTO> GetById(int id)
        {
            try
            {
                var cliente = _lojaContext.Clientes.Find(id);

                if (cliente == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var clienteRead = _mapper.Map<ClienteReadDTO>(cliente);
                return Ok(clienteRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<ClienteReadDTO> Post([FromBody] ClienteCreateDTO clienteCreateDTO)
        {
            try
            {
                var novoCliente = _mapper.Map<ClienteModel>(clienteCreateDTO);

                _lojaContext.Clientes.Add(novoCliente);
                _lojaContext.SaveChanges();

                var novoClienteRead = _mapper.Map<ClienteReadDTO>(novoCliente);

                return StatusCode(HttpStatusCode.Created.GetHashCode(), novoClienteRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        public ActionResult<ClienteReadDTO> Put(int id, [FromBody] ClienteUpdateDTO clienteUpdateDTO)
        {
            try
            {
                var clienteAtualizado = _lojaContext.Clientes.Where(item => item.Id == id).FirstOrDefault();

                if (clienteAtualizado == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                clienteAtualizado = _mapper.Map(clienteUpdateDTO, clienteAtualizado);
                _lojaContext.Clientes.Update(clienteAtualizado);
                _lojaContext.SaveChanges();

                var clienteAtualizadoRead = _mapper.Map<ClienteReadDTO>(clienteAtualizado);
                return Ok(clienteAtualizadoRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            try
            {
                var cliente = _lojaContext.Clientes.Find(id);

                if (cliente == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                _lojaContext.Clientes.Remove(cliente);
                _lojaContext.SaveChanges();
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

    }
}
