using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsVariavel;
using Dominio.Entidades;
using Dominio.Interfaces.Service;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesVariavel
{
    public class VariavelServiceAplicacaoAdd : VariavelServiceAplicacaoBase, ISendService
    {
        private readonly IValoresVariavelService _valoresVariavelService;
        public VariavelServiceAplicacaoAdd(IVariavelService service, InjectorServiceBaseApresentation injector, IValoresVariavelService valoresVariavelService)
            : base(service, injector)
        {
            _valoresVariavelService = valoresVariavelService;
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var modelCast = (VariavelViewModelAdd)model;
            var entidade = base.Injector.Mapper.Map<Variavel>(modelCast);
            await Service.AddAsync(entidade);
            return Injector.Notificador.IsValido();
        }
    }
}
