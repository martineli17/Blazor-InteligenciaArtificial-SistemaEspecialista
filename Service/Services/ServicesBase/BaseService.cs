using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using FluentValidation;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Services.ServicesBase
{
    public class BaseService<TEntidade> : IBaseService<TEntidade> where TEntidade : Base
    {
        protected readonly IBaseRepositorio<TEntidade> Repositorio;
        protected readonly InjectorServiceBase Injector;

        public BaseService(IBaseRepositorio<TEntidade> repositorio, InjectorServiceBase injector)
        {
            Repositorio = repositorio;
            Injector = injector;
        }
        public async Task<TEntidade> AddAsync(TEntidade entidade, AbstractValidator<TEntidade> validation)
        {
            if (Injector.Validator.Executar(validation, entidade))
            {
                await Repositorio.AddAsync(entidade);
                await Injector.UnitOfWork.CommitAsync();
            }
            return entidade;
        }

        public async Task<IQueryable<TEntidade>> GetAsync(Expression<Func<TEntidade, bool>> query = null) => await Repositorio.GetAsync(query);

        public async Task<TEntidade> GetByIdAsync(Guid id) => await Repositorio.GetByIdAsync(id);

        public async Task<bool> RemoveAsync(Guid id)
        {
            if (!await ValidarExistenciaEntidadeAsync(id))
                return false;
            await Repositorio.RemoveAsync(id);
            await Injector.UnitOfWork.CommitAsync();
            return true;
        }

        public async Task<TEntidade> UpdateAsync(TEntidade entidade, AbstractValidator<TEntidade> validation)
        {
            if (!await ValidarExistenciaEntidadeAsync(entidade.Id))
                return entidade;
            if (Injector.Validator.Executar(validation, entidade))
            {
                await Repositorio.UpdateAsync(entidade);
                await Injector.UnitOfWork.CommitAsync();
            }
            return entidade;
        }

        #region Metodos Protecteds
        protected async Task<bool> ValidarExistenciaEntidadeAsync(Guid id)
        {
            if (!await Repositorio.ExistsAsync(x => x.Id == id))
            {
                Injector.Notificador.Add("Registro solicitado não existe.");
                return false;
            }
            return true;
        }
        protected async Task<bool> ValidarExistenciaEntidadeAsync(Expression<Func<TEntidade, bool>> filter)
            => await Repositorio.ExistsAsync(filter);
        protected async Task<bool> CommitAsync() => await Injector.UnitOfWork.CommitAsync();
        #endregion
    }
}
