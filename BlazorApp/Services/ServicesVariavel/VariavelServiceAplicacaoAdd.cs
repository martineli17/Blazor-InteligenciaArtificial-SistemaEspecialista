using BlazorApp.Services.Base;
using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsVariavel;
using Dominio.Entidades;
using Dominio.Interfaces.Service;
using System;
using System.Linq;
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
            var entidadeSalva = await Service.AddAsync(base.Injector.Mapper.Map<Variavel>(modelCast));
            var valores = modelCast.ValoresDaVariavel.Select(x =>
                        new ValoresVariavel
                        {
                            Valor = x,
                            IdProjeto = Injector.ProjetoSelecionado.IdProjetoSelecionado,
                            IdVariavel = entidadeSalva.Id
                        });
            await _valoresVariavelService.AddAsync(valores);
            return Injector.Notificador.IsValido();
        }
    }
}
