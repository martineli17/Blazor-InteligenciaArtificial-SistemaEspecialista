using Dominio.Entidades;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IRegraRepositorio : IBaseRepositorio<Regra>
    {
        Task<IQueryable<Regra>> GetWithIncludesAsync(Expression<Func<Regra, bool>> filter = null);
    }
}
