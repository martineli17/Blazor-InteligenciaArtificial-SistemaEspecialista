using Dominio.Entidades;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IVariavelRepositorio : IBaseRepositorio<Variavel>
    {
        Task<IQueryable<Variavel>> GetWithIncludesAsync(Expression<Func<Variavel, bool>> filter);
    }
}
