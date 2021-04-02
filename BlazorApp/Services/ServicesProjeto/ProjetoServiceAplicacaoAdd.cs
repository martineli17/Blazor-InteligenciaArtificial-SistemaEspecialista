using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsProjeto;
using Dominio.Entidades;
using Dominio.Interfaces.Service;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesProjeto
{
    public class ProjetoServiceAplicacaoAdd : ProjetoServiceAplicacaoBase, ISendService
    {
        public ProjetoServiceAplicacaoAdd(IProjetoService projetoService, InjectorServiceBaseApresentation injector) : base(projetoService, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var entidade = base.Injector.Mapper.Map<Projeto>((ProjetoViewModelAdd)model);
            await ProjetoService.AddAsync(entidade);
            return Injector.Notificador.IsValido();
        }
    }
}
