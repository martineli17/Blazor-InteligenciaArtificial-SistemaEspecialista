using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using Service.Validators.ValidatorsEntidades;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Service.Services
{
    public class VariavelService : BaseService<Variavel>, IVariavelService
    {
        public VariavelService(IVariavelRepositorio repositorio, InjectorServiceBase injector) 
            : base(repositorio, injector)
        {
        }
        public new async Task<Variavel> AddAsync(Variavel entidade)
        {
            if (!Injector.Validator.Executar(new VariavelValidator(), entidade)
                || await ValidarExistenciaEntidadeAsync(x => x.Nome.ToLower() == entidade.Nome.ToLower() 
                                                        && x.IdProjeto == entidade.IdProjeto))
            {
                Injector.Notificador.Add("Variável já existente para este projeto.");
                return null;
            }
            await base.AddAsync(entidade);
            return entidade;
        }

        public new async Task<Variavel> UpdateAsync(Variavel entidade)
        {
            if (!Injector.Validator.Executar(new VariavelValidator(), entidade)
              || await ValidarExistenciaEntidadeAsync(x => x.Nome.ToLower() == entidade.Nome.ToLower() 
                                            && x.Id != entidade.Id && x.IdProjeto == entidade.IdProjeto))
            {
                Injector.Notificador.Add("Variável já existente para este projeto.");
                return null;
            }
            await base.UpdateAsync(entidade);
            return entidade;
        }

        public async Task<IQueryable<Variavel>> GetWithIncludesAsync(Expression<Func<Variavel, bool>> filter = null)
            => await ((IVariavelRepositorio)Repositorio).GetWithIncludesAsync(filter);
    }
}
