using AutoMapper;
using BlazorApp.Services.ServicesProjeto;
using Crosscuting.Notificacao;

namespace BlazorApp.Services.Base
{
    public class InjectorServiceBaseApresentation
    {
        public readonly IMapper Mapper;
        public readonly INotificador Notificador;
        public readonly ProjetoSelecionadoServiceAplicacao ProjetoSelecionado;
        public InjectorServiceBaseApresentation(IMapper mapper, INotificador notificador, 
                                                ProjetoSelecionadoServiceAplicacao projetoSelecionado)
        {
            Mapper = mapper;
            Notificador = notificador;
            ProjetoSelecionado = projetoSelecionado;
        }
    }
}
