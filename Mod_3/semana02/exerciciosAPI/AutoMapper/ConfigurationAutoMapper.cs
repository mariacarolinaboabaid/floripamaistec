using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using exerciciosAPI.DTO.Ficha;
using exerciciosAPI.DTO.Telefone;
using exerciciosAPI.Models;

namespace exerciciosAPI.AutoMapper
{
    public class ConfigurationAutoMapper
    {
        public class ConfigurationMapper : Profile
        {
            public ConfigurationMapper()
            {
                CreateMap<FichaModel, FichaReadDTO>()
                     .ForMember(dest => dest.FichaComDetalhes, opt => opt.MapFrom(src => src.Detalhes));

                CreateMap<FichaCreateDTO, FichaModel>()
                    .ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.NomeCompleto))
                    .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.EmailInformado.ToLower()))
                    .ForMember(dest => dest.DataNascimento, opt => opt.MapFrom(src => src.DataDeNascimento));

                CreateMap<FichaUpdateDTO, FichaModel>();

                CreateMap<DetalheModel, FichaDetalheReadDTO>();

                CreateMap<TelefoneCreateDTO, TelefoneModel>();

                CreateMap<TelefoneModel, TelefoneReadDTO>()
                    .ForMember(destino => destino.Contato, origem => origem.MapFrom(origem => origem.DDD + origem.Numero))
                    .ForMember(destino => destino.FichaTelefone, origem => origem.MapFrom(src => src.Ficha));
                    
                CreateMap<FichaModel, FichaTelefoneReadDTO>();
                
                CreateMap<TelefoneUpdateDTO, TelefoneModel>();

            }
        }
    }
}