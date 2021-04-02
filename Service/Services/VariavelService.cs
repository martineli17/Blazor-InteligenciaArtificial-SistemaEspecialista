using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VariavelService : BaseService<Variavel>, IVariavelService
    {
        public VariavelService(IVariavelRepositorio repositorio, InjectorServiceBase injector) 
            : base(repositorio, injector)
        {
        }
        public async Task<Variavel> AddAsync(Variavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }

        public async Task<Variavel> UpdateAsync(Variavel entidade)
        {
            await base.Repositorio.UpdateAsync(entidade);
            return entidade;
        }

    }
}
