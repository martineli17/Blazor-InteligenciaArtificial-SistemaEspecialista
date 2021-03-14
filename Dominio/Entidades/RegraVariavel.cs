using System;

namespace Dominio.Entidades
{
    public class RegraVariavel : Base
    {
        public Guid IdVariavel { get; init; }
        public Guid IdRegra { get; init; }
        public Regra Regra { get; init; }
        public Variavel Variavel { get; init; }
        public string ValorVariavel { get; init; }
        public bool? Complemento { get; init; }
    }
}
