﻿using BlazorApp.ViewModels.Base;
using System;

namespace BlazorApp.ViewModels.ModelsValoresVariavel
{
    public class ValoresVariavelViewModelGet : IBaseViewModel
    {
        public Guid Id { get; set; }
        public Guid IdVariavel { get; set; }
        public string Valor { get; set; }
    }
}
