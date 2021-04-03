using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using Dominio.Interfaces.Service;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesVariavel
{
    public class VariavelServiceAplicacaoGet : VariavelServiceAplicacaoBase, ISendService
    {
        public VariavelServiceAplicacaoGet(IVariavelService service, InjectorServiceBaseApresentation injector) : base(service, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var variaveisCadastradas = await Service.GetAsync(x => x.IdProjeto == IdProjetoSelecionado);
            return variaveisCadastradas;
        }
    }
}
