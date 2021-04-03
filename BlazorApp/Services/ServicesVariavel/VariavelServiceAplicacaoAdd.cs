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
        public VariavelServiceAplicacaoAdd(IVariavelService service, InjectorServiceBaseApresentation injector) : base(service, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var entidade = base.Injector.Mapper.Map<Variavel>((VariavelViewModelAdd)model);
            await Service.AddAsync(entidade);
            return Injector.Notificador.IsValido();
        }
    }
}
