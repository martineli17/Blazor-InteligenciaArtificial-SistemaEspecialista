using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RegraService : BaseService<Regra>, IRegraService
    {
        public RegraService(IRegraRepositorio repositorio, InjectorServiceBase injector)
            : base(repositorio, injector)
        {
        }

        public async Task<Regra> AddAsync(Regra entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }

        public async Task<Regra> UpdateAsync(Regra entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }
    }
}
