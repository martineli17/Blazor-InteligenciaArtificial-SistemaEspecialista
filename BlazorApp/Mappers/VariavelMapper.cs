using AutoMapper;
using BlazorApp.ViewModels.ModelsVariavel;
using Dominio.Entidades;
using System.Linq;

namespace BlazorApp.Mappers
{
    public class VariavelMapper : Profile
    {
        public VariavelMapper()
        {
            CreateMap<VariavelViewModelAdd, Variavel>()
                .ForMember(dest => dest.Valores, options => options.MapFrom((src, dest) => src.ValoresDaVariavel.Select(x =>
                        new ValoresVariavel
                        {
                            Valor = x,
                            IdProjeto = src.IdProjeto,
                            IdVariavel = dest.Id
                        }).ToList()));
            CreateMap<Variavel, VariavelViewModelGet>().ReverseMap();
        }
    }
}
