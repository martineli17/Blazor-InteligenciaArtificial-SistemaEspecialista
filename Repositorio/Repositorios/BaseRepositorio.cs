﻿using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : Base
    {
        protected readonly Context Context;
        protected readonly INotificador Notificador;

        public BaseRepositorio(Context context, INotificador notificador)
        {
            Context = context;
            Notificador = notificador;
        }

        public virtual async Task AddAsync(TEntity entidade) 
        {
            await Context.Set<TEntity>().AddAsync(entidade);
        }

        public virtual async Task AddAsync(IEnumerable<TEntity> entidades) 
        {
            await Context.Set<TEntity>().AddRangeAsync(entidades);
        }

        public virtual async Task<IQueryable<TEntity>> GetAsync(Func<TEntity, bool> query = null)
        {
            await Task.Yield();
            return Context.Set<TEntity>().Where(query).AsQueryable();
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            var entidade = await Context.Set<TEntity>().FindAsync(id);
            if (entidade != null)
                Context.Entry(entidade).State = EntityState.Detached;
            return entidade;
        }

        public virtual async Task RemoveAsync(Guid id)
        {
            var entidade = await GetByIdAsync(id);
            if (entidade == null)
            {
                Notificador.Add("Registro não encontrado.");
                return;
            }
            Context.Set<TEntity>().Remove(entidade);
        }

        public virtual async Task RemoveAsync(IEnumerable<Guid> id)
        {
            await Task.Yield();
            var entidades = Context.Set<TEntity>().Where(x => id.Contains(x.Id));
            Context.Set<TEntity>().RemoveRange(entidades);
        }

        public virtual async Task UpdateAsync(TEntity entidade)
        {
            await Task.Yield();
            Context.Set<TEntity>().Update(entidade);
        }

        public virtual async Task UpdateAsync(IEnumerable<TEntity> entidades)
        {
            await Task.Yield();
            Context.Set<TEntity>().UpdateRange(entidades);
        }
    }
}
