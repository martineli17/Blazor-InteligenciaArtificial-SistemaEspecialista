using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using Dominio.Interfaces.Service;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesRegra
{
    public class RegraServiceAplicacaoCount : RegraServiceAplicacaoBase, ISendService
    {
        public RegraServiceAplicacaoCount(IRegraService service, InjectorServiceBaseApresentation injector) : base(service, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var regrasCadastradas = await Service.GetAsync();
            regrasCadastradas = regrasCadastradas.Where(x => x.IdProjeto == IdProjetoSelecionado);
            return regrasCadastradas.Count();
        }
    }
}
