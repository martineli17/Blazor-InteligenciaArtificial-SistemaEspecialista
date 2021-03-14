using System;

namespace Dominio.Entidades
{
    public class ValoresVariavel : Base
    {
        public Guid IdVariavel { get; init; }
        public string Valor { get; init; }
        public Variavel Variavel { get; init; }
    }
}
