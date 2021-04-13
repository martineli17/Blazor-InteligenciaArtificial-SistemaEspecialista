using BlazorApp.ViewModels.Base;
using System;
using System.Collections.Generic;

namespace BlazorApp.ViewModels.ModelsRegra
{
    public class RegraViewModelRespostaCollection : IBaseViewModel
    {
        public ICollection<RegraViewModelValidar> Respostas { get; set; } = new List<RegraViewModelValidar>();
        public ICollection<RegraViewModelGet> ViewModelGet { get; set; } = new List<RegraViewModelGet>();
    }
    public class RegraViewModelResultado
    {
        public RegraViewModelResultado(string valorObjetivo, string nomeObjetivo)
        {
            ValorObjetivo = valorObjetivo;
            NomeObjetivo = nomeObjetivo;
        }

        public string ValorObjetivo { get; set; }
        public string NomeObjetivo { get; set; }
        public int Ponto { get; set; }

    }
    public class RegraViewModelValidar
    {
        public Guid IdRegra { get; set; }
        public Guid IdVariavel { get; set; }
        public string ValorVariavel { get; set; }
    }
}
