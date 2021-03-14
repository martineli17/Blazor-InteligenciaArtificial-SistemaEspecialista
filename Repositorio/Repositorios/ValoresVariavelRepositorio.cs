using Crosscuting.Notificacao;
using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Repositorio.Contexto;

namespace Repositorio.Repositorios
{
    public class ValoresVariavelRepositorio : BaseRepositorio<ValoresVariavel>, IValoresVariavelRepositorio
    {
        public ValoresVariavelRepositorio(Context context, INotificador notificador) : base(context, notificador)
        {
        }
    }
}
