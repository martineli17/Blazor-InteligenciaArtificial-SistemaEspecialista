using BlazorApp.ViewModels.Base;
using Dominio.ValuesType;
using System;
using System.Collections.Generic;

namespace BlazorApp.ViewModels.ModelsRegra
{
    public class RegraViewModelAdd : IBaseViewModel
    {
        public Guid IdProjeto { get; set; }
        public List<RegraVariavelViewModel> RegrasVariavel { get; set; } = new List<RegraVariavelViewModel>();
        public Guid IdVariavelObjetivo { get; set; }
        public string ValorVariavelObjetivo { get; set; }
        public EnumTipoComplemento? Complemento { get; set; }
    }

    public class RegraVariavelViewModel
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
        public Guid Id { get; set; }
    }
}
