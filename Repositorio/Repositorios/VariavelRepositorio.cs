using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class VariavelRepositorio : BaseRepositorio<Variavel>, IVariavelRepositorio
    {
        public VariavelRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }
    }
}
