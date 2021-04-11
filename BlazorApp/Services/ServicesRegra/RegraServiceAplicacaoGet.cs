using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsRegra;
using Crosscuting.Extensions;
using Dominio.Interfaces.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesRegra
{
    public class RegraServiceAplicacaoGet : RegraServiceAplicacaoBase, ISendService
    {
        public RegraServiceAplicacaoGet(IRegraService service, InjectorServiceBaseApresentation injector) : base(service, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var modelCast = (RegraViewModelFiltroGet)model;
            var regrasCadastradas = await Service.GetWithIncludesAsync();
            regrasCadastradas = regrasCadastradas.Where(x => x.IdProjeto == IdProjetoSelecionado);
            if (modelCast != null)
                regrasCadastradas = regrasCadastradas.Skip(modelCast.GetSkip()).Take(modelCast.Take);
            return Injector.Mapper.Map<IEnumerable<RegraViewModelGet>>(regrasCadastradas);
        }
    }
}
