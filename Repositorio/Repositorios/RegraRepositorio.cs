using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class RegraRepositorio : BaseRepositorio<Regra>, IRegraRepositorio
    {
        public RegraRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }
    }
}
