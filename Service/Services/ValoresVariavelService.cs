using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ValoresVariavelService : BaseService<ValoresVariavel>, IValoresVariavelService
    {
        public ValoresVariavelService(IValoresVariavelRepositorio repositorio, InjectorServiceBase injector) 
            : base(repositorio, injector)
        {
        }

        public async Task<ValoresVariavel> AddAsync(ValoresVariavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }

        public async Task<ValoresVariavel> UpdateAsync(ValoresVariavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }
    }
}
