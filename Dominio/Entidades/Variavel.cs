using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Variavel : Base
    {
        public string Nome { get; init; }
        public bool Objetivo { get; init; }
        public Guid IdValoresVariavel { get; set; }
        public IEnumerable<ValoresVariavel> Valores { get; init; }
    }
}
