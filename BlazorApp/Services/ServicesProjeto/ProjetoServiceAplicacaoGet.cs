using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Service;
using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsProjeto;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp.Services.ServicesProjeto
{
    public class ProjetoServiceAplicacaoGet : ProjetoServiceAplicacaoBase, ISendService
    {
        public ProjetoServiceAplicacaoGet(IProjetoService projetoService, InjectorServiceBaseApresentation injector) : base(projetoService, injector)
        {
        }

        public async Task<object> SendService(IBaseViewModel model = null)
        {
            var projetos = await ProjetoService.GetAsync();
            System.Console.WriteLine(projetos.FirstOrDefault()?.Nome);
            return Injector.Mapper.Map<IEnumerable<ProjetoViewModelGet>>(projetos);
        }
    }
}
