using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsRegra;
using Crosscuting.Extensions;
using Dominio.Entidades;
using Dominio.Interfaces.Service;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.ServicesRegra
{
    public class RegraServiceAplicacaoResultado : RegraServiceAplicacaoBase, ISendService
    {
        public RegraServiceAplicacaoResultado(IRegraService regraService, InjectorServiceBaseApresentation injector)
            : base(regraService, injector)
        {
        }
        public async Task<object> SendService(IBaseViewModel model = null)
        {
            await Task.Yield();
            ICollection<RegraViewModelResultado> resultadosGerados = new List<RegraViewModelResultado>();
            var modelCast = (RegraViewModelRespostaCollection)model;
            var entidades = base.Injector.Mapper.Map<IEnumerable<Regra>>(modelCast.ViewModelGet);
            foreach (var entidade in entidades)
            {
                if (entidade.ValidarRegra(modelCast.Respostas.Where(x =>
                            entidade.RegrasVariavel.Any(rv => rv.IdVariavel == x.IdVariavel))
                            .Select(x => (x.IdVariavel, x.ValorVariavel))))
                {
                    var listaVariaveis = modelCast.ViewModelGet.Where(x => x.Id == entidade.Id).SelectMany(x => x.RegrasVariavel);
                    resultadosGerados.Add(new RegraViewModelResultado(entidade.ValorVariavelObjetivo, entidade.VariavelObjetivo.Nome));
                }
            }
            return resultadosGerados;
        }
    }
}
