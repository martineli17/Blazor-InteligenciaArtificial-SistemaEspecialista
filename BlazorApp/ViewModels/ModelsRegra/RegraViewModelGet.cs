using BlazorApp.ViewModels.Base;
using BlazorApp.ViewModels.ModelsVariavel;
using System;
using System.Collections.Generic;

namespace BlazorApp.ViewModels.ModelsRegra
{
    public class RegraViewModelFiltroGet : IBaseViewModel
    {
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = int.MaxValue;
        public int GetSkip() => (Skip > 0) ? (Skip - 1) * Take : 0;
        public RegraViewModelFiltroGet()
        {

        }
        public RegraViewModelFiltroGet(int take)
        {
            Take = take;
        }
    }

    public class RegraViewModelGet
    {
        public Guid Id { get; set; }
        public Guid IdProjeto { get; set; }
        public IEnumerable<RegraVariavelViewModelGet> RegrasVariavel { get; set; }
        public Guid IdVariavelObjetivo { get; set; }
        public VariavelViewModelGet VariavelObjetivo { get; set; }
        public string ValorVariavelObjetivo { get; set; }
        public string Complemento { get; set; }
    }

    public class RegraVariavelViewModelGet
    {
        public Guid IdVariavel { get; set; }
        public Guid IdRegra { get; set; }
        public VariavelViewModelGet Variavel { get; set; }
        public string ValorVariavel { get; set; }
    }
}
