using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Variavel : Base
    {
        public string Nome { get; init; }
        public bool Objetivo { get; init; }
        public string Pergunta { get; init; }
        public string MotivoPergunta { get; init; }
        public IEnumerable<ValoresVariavel> Valores { get; init; }
        public IEnumerable<RegraVariavel> RegrasVariavel { get; init; }
        public IEnumerable<Regra> Regras { get; init; }
    }
}
