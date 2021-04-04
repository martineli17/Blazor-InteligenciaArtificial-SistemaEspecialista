using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IValoresVariavelService : IBaseServiceEspecifico<ValoresVariavel>, IBaseService<ValoresVariavel>
    {
        Task<IEnumerable<ValoresVariavel>> AddAsync(IEnumerable<ValoresVariavel> entidade);
    }
}
