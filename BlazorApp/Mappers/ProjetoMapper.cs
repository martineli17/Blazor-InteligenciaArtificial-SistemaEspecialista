using AutoMapper;
using Dominio.Entidades;
using BlazorApp.ViewModels.ModelsProjeto;

namespace BlazorApp.Mappers
{
    public class ProjetoMapper : Profile
    {
        public ProjetoMapper()
        {
            CreateMap<ProjetoViewModelAdd, Projeto>();
            CreateMap<Projeto, ProjetoViewModelGet>();
        }
    }
}
