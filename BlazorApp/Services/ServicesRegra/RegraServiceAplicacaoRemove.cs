using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using Dominio.Interfaces.Service;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesRegra
{
    public class RegraServiceAplicacaoRemove : RegraServiceAplicacaoBase, ISendService
    {
        public RegraServiceAplicacaoRemove(IRegraService service, InjectorServiceBaseApresentation injector) 
            : base(service, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            await Service.RemoveAsync(((BaseRemoveViewModel)model).Id);
            return Injector.Notificador.IsValido();
        }
    }
}
