using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using loja.Context;
using loja.Dto.Produto;
using loja.Models;
using Microsoft.AspNetCore.Mvc;

namespace loja.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProdutoController : ControllerBase
    {


        private readonly LojaContext _lojaContext;
        private readonly IMapper _mapper;


        public ProdutoController(LojaContext lojaContext, IMapper mapper)
        {
            _lojaContext = lojaContext;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProdutoReadDTO>> GetAll()
        {
            try
            {
                List<ProdutoModel> listaProdutos;

                listaProdutos = _lojaContext.Produtos.ToList();

                if (listaProdutos.Count() == 0)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var listaProdutosRead = _mapper.Map<List<ProdutoReadDTO>>(listaProdutos);

                return Ok(listaProdutosRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }

        }

        [HttpGet("{id}")]
        public ActionResult<ProdutoReadDTO> GetById(int id)
        {
            try
            {
                var produto = _lojaContext.Produtos.Find(id);

                if (produto == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                var produtoRead = _mapper.Map<ProdutoReadDTO>(produto);
                return Ok(produtoRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        public ActionResult<ProdutoReadDTO> Post([FromBody] ProdutoCreateDTO produtoCreateDTO)
        {
            try
            {
                var novoProduto = _mapper.Map<ProdutoModel>(produtoCreateDTO);

                _lojaContext.Produtos.Add(novoProduto);
                _lojaContext.SaveChanges();

                var novoProdutoRead = _mapper.Map<ProdutoReadDTO>(novoProduto);

                return StatusCode(HttpStatusCode.Created.GetHashCode(), novoProdutoRead);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        public ActionResult<ProdutoReadDTO> Put(int id, [FromBody] ProdutoUpdateDTO produtoUpdateDTO)
        {
            try
            {
                var produtoAtualizado = _lojaContext.Produtos.Where(item => item.Id == id).FirstOrDefault();

                if (produtoAtualizado == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                produtoAtualizado = _mapper.Map(produtoUpdateDTO, produtoAtualizado);
                _lojaContext.Produtos.Update(produtoAtualizado);
                _lojaContext.SaveChanges();

                var produtoAtualizadoRead = _mapper.Map<ProdutoReadDTO>(produtoAtualizado);
                return Ok(produtoAtualizadoRead);
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
                var produto = _lojaContext.Produtos.Find(id);

                if (produto == null)
                {
                    return NotFound("Nenhum registro foi encontrado!");
                }

                _lojaContext.Produtos.Remove(produto);
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
