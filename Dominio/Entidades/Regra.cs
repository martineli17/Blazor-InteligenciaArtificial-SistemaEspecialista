using Dominio.ValuesType;
using System;
using System.Collections.Generic;

namespace Dominio.Entidades
{
    public class Regra : BaseProjeto
    {
        public IEnumerable<RegraVariavel> RegrasVariavel { get; set; }
        public Guid IdVariavelObjetivo { get; set; }
        public Variavel VariavelObjetivo { get; set; }
        public string ValorVariavelObjetivo { get; set; }
        public EnumTipoComplemento? Complemento { get; set; }
    }
}
