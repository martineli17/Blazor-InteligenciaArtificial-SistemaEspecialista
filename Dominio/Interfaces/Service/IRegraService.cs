using Dominio.Entidades;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Service
{
    public interface IRegraService : IBaseServiceEspecifico<Regra>, IBaseService<Regra>
    {
        Task<IQueryable<Regra>> GetWithIncludesAsync(Expression<Func<Regra, bool>> filter = null);
    }
}
