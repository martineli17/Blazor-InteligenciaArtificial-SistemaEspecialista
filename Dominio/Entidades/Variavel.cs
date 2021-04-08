using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Variavel : BaseProjeto
    {
        public string Nome { get; set; }
        public bool Objetivo { get; set; }
        public string Pergunta { get; set; }
        public string MotivoPergunta { get; set; }
        public ICollection<ValoresVariavel> Valores { get; set; }
        public IEnumerable<RegraVariavel> RegrasVariavel { get; set; }
        public IEnumerable<Regra> Regras { get; set; }
    }
}
