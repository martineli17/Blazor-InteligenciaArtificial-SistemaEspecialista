using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsVariavel;
using Dominio.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesVariavel
{
    public class VariavelServiceAplicacaoRemove : VariavelServiceAplicacaoBase, ISendService
    {
        public VariavelServiceAplicacaoRemove(IVariavelService service, InjectorServiceBaseApresentation injector) : base(service, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            await Service.RemoveAsync(((BaseRemoveViewModel)model).Id);
            return Injector.Notificador.IsValido();
        }
    }
}
