using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using Service.Validators.ValidatorsEntidades;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RegraService : BaseService<Regra>, IRegraService
    {
        public RegraService(IRegraRepositorio repositorio, InjectorServiceBase injector)
            : base(repositorio, injector)
        {
        }

        public new async Task<Regra> AddAsync(Regra entidade)
        {
            if (!Injector.Validator.Executar(new RegraValidator(), entidade)) return null;
            await base.AddAsync(entidade);
            return entidade;
        }

        public new async Task<Regra> UpdateAsync(Regra entidade)
        {
            if (!Injector.Validator.Executar(new RegraValidator(), entidade)) return null;
            await base.UpdateAsync(entidade);
            return entidade;
        }

        public async Task<IQueryable<Regra>> GetWithIncludesAsync(Expression<Func<Regra, bool>> filter = null)
           => await ((IRegraRepositorio)Repositorio).GetWithIncludesAsync(filter);
    }
}
