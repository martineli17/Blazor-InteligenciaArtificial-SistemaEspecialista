using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsVariavel;
using Dominio.Interfaces.Service;
using System.Collections.Generic;
using System.Linq;
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
            var variaveisCadastradas = await Service.GetWithIncludesAsync();
            return Injector.Mapper.Map<IEnumerable<VariavelViewModelGet>>(variaveisCadastradas
                                             .Where(x => x.IdProjeto == IdProjetoSelecionado));
        }
    }
}
