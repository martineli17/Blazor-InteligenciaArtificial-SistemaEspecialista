using BlazorApp.ViewModels.ModelsValoresVariavel;
using System;
using System.Collections.Generic;

namespace BlazorApp.ViewModels.ModelsVariavel
{
    public class VariavelViewModelGet : VariavelViewModelBase
    {
        public Guid Id { get; set; }
        public List<ValoresVariavelViewModelGet> Valores { get; set; }
    }
}
