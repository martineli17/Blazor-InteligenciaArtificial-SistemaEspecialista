using BlazorApp.Services.Base;
using Dominio.Interfaces.Service;

namespace BlazorApp.Services.ServicesRegra
{
    public class RegraServiceAplicacaoBase : ServiceBase
    {
        protected readonly IRegraService Service;
        public RegraServiceAplicacaoBase(IRegraService service, InjectorServiceBaseApresentation injector)
            : base(injector)
        {
            Service = service;
        }
    }
}
