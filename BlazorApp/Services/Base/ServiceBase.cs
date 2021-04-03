using System;

namespace BlazorApp.Services.Base
{
    public class ServiceBase
    {
        public readonly InjectorServiceBaseApresentation Injector;
        public readonly Guid IdProjetoSelecionado;
        public ServiceBase(InjectorServiceBaseApresentation injector)
        {
            Injector = injector;
            IdProjetoSelecionado = Injector.ProjetoSelecionado.IdProjetoSelecionado;
        }
    }
}
