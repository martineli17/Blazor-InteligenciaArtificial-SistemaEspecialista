using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsRegra;
using Dominio.Entidades;
using Dominio.Interfaces.Service;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesRegra
{
    public class RegraServiceAplicacaoAdd : RegraServiceAplicacaoBase, ISendService
    {
        public RegraServiceAplicacaoAdd(IRegraService regraService, InjectorServiceBaseApresentation injector) 
            : base(regraService, injector)
        {
        }
        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var modelCast = (RegraViewModelAdd)model;
            var entidade = base.Injector.Mapper.Map<Regra>(modelCast);
            entidade.IdProjeto = IdProjetoSelecionado;
            await Service.AddAsync(entidade);
            return Injector.Notificador.IsValido();
        }
    }
}
