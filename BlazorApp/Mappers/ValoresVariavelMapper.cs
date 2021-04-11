using AutoMapper;
using BlazorApp.ViewModels.ModelsValoresVariavel;
using Dominio.Entidades;

namespace BlazorApp.Mappers
{
    public class ValoresVariavelMapper : Profile
    {
        public ValoresVariavelMapper()
        {
            CreateMap<ValoresVariavel, ValoresVariavelViewModelGet>().ReverseMap();
        }
    }
}
