using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class RegraVariavelRepositorio : BaseRepositorio<RegraVariavel>, IRegraVariavelRepositorio
    {
        public RegraVariavelRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }
    }
}
