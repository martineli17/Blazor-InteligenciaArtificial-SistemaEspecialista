using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using Service.Validators.ValidatorsEntidades;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ValoresVariavelService : BaseService<ValoresVariavel>, IValoresVariavelService
    {
        public ValoresVariavelService(IValoresVariavelRepositorio repositorio, InjectorServiceBase injector)
            : base(repositorio, injector)
        {
        }

        public new async Task<ValoresVariavel> AddAsync(ValoresVariavel entidade)
        {
            if (!Injector.Validator.Executar(new ValoresVariavelValidator(), entidade) ||
                await ValidarExistenciaEntidadeAsync(x => entidade.Valor == x.Valor && x.IdVariavel == entidade.IdVariavel))
            {
                Injector.Notificador.Add("Valor já existente para esta variável.");
                return null;
            }
            await base.AddAsync(entidade);
            return entidade;
        }

        public new async Task<IEnumerable<ValoresVariavel>> AddAsync(IEnumerable<ValoresVariavel> entidade)
        {
            var idVariavel = entidade.FirstOrDefault()?.IdVariavel;
            var valores = entidade.Select(x => x.Valor);
            if (!Injector.Validator.Executar(new ValoresVariavelsValidator(), entidade) ||
                await ValidarExistenciaEntidadeAsync(x => valores.Contains(x.Valor) && x.IdVariavel == idVariavel))
            {
                Injector.Notificador.Add("Valor já existente para esta variável.");
                return null;
            }
            await base.AddAsync(entidade);
            return entidade;
        }

        public new async Task<ValoresVariavel> UpdateAsync(ValoresVariavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }
    }
}
