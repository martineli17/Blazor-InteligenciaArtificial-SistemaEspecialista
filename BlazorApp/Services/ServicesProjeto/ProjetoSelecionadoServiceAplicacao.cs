using System;

namespace BlazorApp.Services.ServicesProjeto
{
    public class ProjetoSelecionadoServiceAplicacao
    {
        public Guid IdProjetoSelecionado { get; set; } = Guid.Empty;
        public string NomeProjetoSelecionado { get; set; }
    }
}
