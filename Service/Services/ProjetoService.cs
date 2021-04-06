using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Service.Services.ServicesBase;
using Service.Validators.ValidatorsEntidades;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProjetoService : BaseService<Projeto>, IProjetoService
    {
        public ProjetoService(IProjetoRepositorio repositorio, InjectorServiceBase injector) 
            : base(repositorio, injector)
        {
        }

        public new async Task<Projeto> AddAsync(Projeto entidade)
        {
            if (!Injector.Validator.Executar(new ProjetoValidator(), entidade)) return null;
            if(await ValidarExistenciaEntidadeAsync(x => x.Nome.ToLower() == entidade.Nome.ToLower()))
            {
                Injector.Notificador.Add("Projeto já existente.");
                return null;
            }
            await base.AddAsync(entidade);
            return entidade;
        }

        public new async Task<Projeto> UpdateAsync(Projeto entidade)
        {
            if (!Injector.Validator.Executar(new ProjetoValidator(), entidade)) return null;
            if (await ValidarExistenciaEntidadeAsync(x => x.Nome.ToLower() == entidade.Nome.ToLower() && x.Id != entidade.Id))
            {
                Injector.Notificador.Add("Projeto já existente.");
                return null;
            }
            await base.UpdateAsync(entidade);
            return entidade;
        }
    }
}
