using System;

namespace Dominio.Entidades
{
    public class RegraVariavel : BaseProjeto
    {
        public Guid IdVariavel { get; set; }
        public Guid IdRegra { get; set; }
        public Regra Regra { get; set; }
        public Variavel Variavel { get; set; }
        public string ValorVariavel { get; set; }
    }
}
