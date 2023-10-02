using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using loja.Context;
using loja.Dto.Venda;
using loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace loja.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendaController : ControllerBase
    {
        private readonly LojaContext _lojaContext;
        private readonly IMapper _mapper;


        public VendaController(LojaContext lojaContext, IMapper mapper)
        {
            _lojaContext = lojaContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<VendaReadDTO>> GetAll()
        {
            try
            {
                List<VendaModel> listaVendas;
              
                listaVendas = _lojaContext.Vendas.ToList();
                
                if (listaVendas.Count() == 0)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var listaVendasRead = _mapper.Map<List<VendaReadDTO>>(listaVendas);

                return Ok(listaVendasRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<VendaReadDTO> GetById(int id)
        {
            try
            {
                var venda = _lojaContext.Vendas.Find(id);

                if (venda == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var vendaRead = _mapper.Map<VendaReadDTO>(venda);
                return Ok(vendaRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<VendaReadDTO> Post([FromBody] VendaCreateDTO vendaCreateDTO)
        {
            try
            {
                var novaVenda = _mapper.Map<VendaModel>(vendaCreateDTO);

                _lojaContext.Vendas.Add(novaVenda);
                _lojaContext.SaveChanges();

                var novaVendaRead = _mapper.Map<VendaReadDTO>(novaVenda);

                return StatusCode(HttpStatusCode.Created.GetHashCode(), novaVendaRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        public ActionResult<VendaReadDTO> Put(int id, [FromBody] VendaUpdateDTO vendaUpdateDTO)
        {
            try
            {
                var vendaAtualizada = _lojaContext.Vendas.Where(item => item.Id == id).FirstOrDefault();

                if (vendaAtualizada == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                vendaAtualizada = _mapper.Map(vendaUpdateDTO, vendaAtualizada);
                _lojaContext.Vendas.Update(vendaAtualizada);
                _lojaContext.SaveChanges();

                var vendaAtualizadaRead = _mapper.Map<VendaReadDTO>(vendaAtualizada);
                return Ok(vendaAtualizadaRead);
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
                var venda = _lojaContext.Vendas.Find(id);

                if (venda == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                _lojaContext.Vendas.Remove(venda);
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
