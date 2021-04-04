using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using System.Threading.Tasks;

namespace Service.Services
{
    public class RegraVariavelService : BaseService<RegraVariavel>, IRegraVariavelService
    {
        public RegraVariavelService(IRegraVariavelRepositorio repositorio, InjectorServiceBase injector) 
            : base(repositorio, injector)
        {
        }

        public new async Task<RegraVariavel> AddAsync(RegraVariavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }

        public new async Task<RegraVariavel> UpdateAsync(RegraVariavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }
    }
}
