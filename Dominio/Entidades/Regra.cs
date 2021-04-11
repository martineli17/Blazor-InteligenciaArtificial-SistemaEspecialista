using Dominio.ValuesType;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominio.Entidades
{
    public class Regra : BaseProjeto
    {
        public ICollection<RegraVariavel> RegrasVariavel { get; set; }
        public Guid IdVariavelObjetivo { get; set; }
        public Variavel VariavelObjetivo { get; set; }
        public string ValorVariavelObjetivo { get; set; }
        public EnumTipoComplemento Complemento { get; set; }

        public bool ValidarRegra(IEnumerable<(Guid IdVariavel, string ValorVariavel)> variaveis)
        {
            if (RegrasVariavel is null) return false;
            if (variaveis.Count() > RegrasVariavel.Count()) return false;
            if (Complemento == EnumTipoComplemento.AND)
                return RegrasVariavel.ToList()
                    .TrueForAll(x => variaveis.Any(v => v.IdVariavel == x.IdVariavel && x.ValorVariavel == v.ValorVariavel));
            return
                RegrasVariavel.ToList()
                   .Any(x => variaveis.Any(v => v.IdVariavel == x.IdVariavel && x.ValorVariavel == v.ValorVariavel));
        }
    }
}
