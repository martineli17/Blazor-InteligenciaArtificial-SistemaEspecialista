using BlazorApp.ViewModels.Base;
using System;

namespace BlazorApp.ViewModels.ModelsVariavel
{
    public class VariavelViewModelBase : IBaseViewModel
    {
        public Guid IdProjeto { get; set; }
        public string Nome { get; set; }
        public bool Objetivo { get; set; }
        public string Pergunta { get; set; }
        public string MotivoPergunta { get; set; }
    }
}
