using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using loja.Models;
using loja.Dto.Cliente;
using loja.Dto.Produto;
using loja.Dto.Venda;

namespace loja.AutoMapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ClienteCreateDTO, ClienteModel>();
            CreateMap<ClienteUpdateDTO, ClienteModel>();
            CreateMap<ClienteModel, ClienteReadDTO>();

            CreateMap<ProdutoCreateDTO, ProdutoModel>();
            CreateMap<ProdutoUpdateDTO, ProdutoModel>();
            CreateMap<ProdutoModel, ProdutoReadDTO>();

            CreateMap<VendaCreateDTO, VendaModel>();
            CreateMap<VendaUpdateDTO, VendaModel>();
            CreateMap<VendaModel, VendaReadDTO>();
        }
    }
}