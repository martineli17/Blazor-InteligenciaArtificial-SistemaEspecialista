using BlazorApp.Services.Base;
using Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesVariavel
{
    public class VariavelServiceAplicacaoBase : ServiceBase
    {
        protected readonly IVariavelService Service;
        public VariavelServiceAplicacaoBase(IVariavelService service, InjectorServiceBaseApresentation injector)
            : base(injector)
        {
            Service = service;
        }
    }
}
