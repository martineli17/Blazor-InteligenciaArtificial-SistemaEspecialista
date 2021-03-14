using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class ProjetoRepositorio : BaseRepositorio<Projeto>, IProjetoRepositorio
    {
        public ProjetoRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }
    }
}
