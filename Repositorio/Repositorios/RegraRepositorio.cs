using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
    public class RegraRepositorio : BaseRepositorio<Regra>, IRegraRepositorio
    {
        public RegraRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }

        public Task<IQueryable<Regra>> GetWithIncludesAsync(Expression<Func<Regra, bool>> filter = null)
        {
            var query = Context.Variavel.AsQueryable();
            if (filter != null)
                return Task.FromResult(Context.Regra.Where(filter).Include(x => x.RegrasVariavel).ThenInclude(x => x.Variavel).Include(x => x.VariavelObjetivo).AsQueryable());
            else
                return Task.FromResult(Context.Regra.Include(x => x.RegrasVariavel).ThenInclude(x => x.Variavel).Include(x => x.VariavelObjetivo).AsQueryable());
        }
    }
}
