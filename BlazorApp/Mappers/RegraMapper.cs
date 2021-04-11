using AutoMapper;
using BlazorApp.ViewModels.ModelsRegra;
using Crosscuting.Extensions;
using Dominio.Entidades;
using Dominio.ValuesType;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Mappers
{
    public class RegraMapper : Profile
    {
        public RegraMapper()
        {
            CreateMap<RegraViewModelAdd, Regra>()
                 .ForMember(dest => dest.RegrasVariavel, options => options.MapFrom((src, dest) => src.RegrasVariavel.Select(x =>
                        new RegraVariavel
                        {
                            IdRegra = dest.Id,
                            IdProjeto = src.IdProjeto,
                            IdVariavel = x.Id,
                            ValorVariavel = x.Valor
                        }).ToList()));

            CreateMap<RegraVariavel, RegraVariavelViewModelGet>().ReverseMap();
            CreateMap<Regra, RegraViewModelGet>()
                               .ForMember(dest => dest.Complemento, options => options.MapFrom(src => src.Complemento == EnumTipoComplemento.AND ? "Todas" : "Mínimo uma"));
            CreateMap<RegraViewModelGet, Regra>()
               .ForMember(dest => dest.Complemento, options => options.MapFrom(src => src.Complemento == "Mínimo uma" ? EnumTipoComplemento.OR : EnumTipoComplemento.AND));
        }
    }
}
