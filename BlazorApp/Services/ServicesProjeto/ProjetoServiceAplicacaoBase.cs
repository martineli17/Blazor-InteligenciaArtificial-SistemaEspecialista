using Dominio.Interfaces.Service;
using BlazorApp.Services.Base;

namespace BlazorApp.Services.ServicesProjeto
{
    public class ProjetoServiceAplicacaoBase : ServiceBase
    {
        protected readonly IProjetoService ProjetoService;
        public ProjetoServiceAplicacaoBase(IProjetoService projetoService, InjectorServiceBaseApresentation injector)
            : base(injector)
        {
            ProjetoService = projetoService;
        }
    }
}
