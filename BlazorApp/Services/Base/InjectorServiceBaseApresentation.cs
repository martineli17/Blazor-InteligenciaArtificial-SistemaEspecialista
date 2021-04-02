﻿using AutoMapper;
using Crosscuting.Notificacao;

namespace BlazorApp.Services.Base
{
    public class InjectorServiceBaseApresentation
    {
        public readonly IMapper Mapper;
        public readonly INotificador Notificador;
        public InjectorServiceBaseApresentation(IMapper mapper, INotificador notificador)
        {
            Mapper = mapper;
            Notificador = notificador;
        }
    }
}
