using AutoMapper;
using BlazorApp.ViewModels.ModelsVariavel;
using Dominio.Entidades;

namespace BlazorApp.Mappers
{
    public class VariavelMapper : Profile
    {
        public VariavelMapper()
        {
            CreateMap<VariavelViewModelAdd, Variavel>();
            CreateMap<Variavel, VariavelViewModelGet>();
        }
    }
}
