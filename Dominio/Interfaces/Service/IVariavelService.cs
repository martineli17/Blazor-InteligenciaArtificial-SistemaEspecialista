using Dominio.Entidades;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IVariavelService : IBaseServiceEspecifico<Variavel>, IBaseService<Variavel>
    {
        Task<IQueryable<Variavel>> GetWithIncludesAsync(Expression<Func<Variavel, bool>> filter = null);
    }
}
