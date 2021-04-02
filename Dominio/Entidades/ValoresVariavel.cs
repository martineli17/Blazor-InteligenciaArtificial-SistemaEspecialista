using System;

namespace Dominio.Entidades
{
    public class ValoresVariavel : BaseProjeto
    {
        public Guid IdVariavel { get; set; }
        public string Valor { get; set; }
        public Variavel Variavel { get; set; }
    }
}
