using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Regra : Base
    {
        public IEnumerable<RegraVariavel> RegrasVariavel { get; init; }
        public Guid IdVariavelObjetivo { get; init; }
        public Variavel VariavelObjetivo { get; init; }
        public string ValorVariavelObjetivo { get; init; }
    }
}
