using Crosscuting.Notificacao;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using BlazorApp.Services.Base;
using BlazorApp.Services.ServicesProjeto;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Repositorio.Contexto;
using Repositorio.Repositorios;
using Repositorio.UnitOfWork;
using Service.Services;
using Service.Services.ServicesBase;
using Service.Validators.ValidadorBase;
using System;
using BlazorApp.Services.ServicesVariavel;

namespace BlazorApp.Configuracoes
{
    public static class IoC
    {
        public static IServiceCollection AddInjecaoDependencia(this IServiceCollection service)
        {
            #region CrossCutting
            service.TryAddScoped<INotificador, Notificador>();
            service.TryAddScoped(provider => new Lazy<INotificador>(provider.GetService<INotificador>));
            #endregion

            #region Repositorios
            service.TryAddScoped<Context>();
            service.TryAddTransient<IUnitOfWork, UnitOfWork>();
            service.TryAddTransient<IProjetoRepositorio, ProjetoRepositorio>();
            service.TryAddTransient<IVariavelRepositorio, VariavelRepositorio>();
            service.TryAddTransient<IValoresVariavelRepositorio, ValoresVariavelRepositorio>();
            #endregion

            #region Services
            service.TryAddScoped<InjectorServiceBase>();
            service.TryAddTransient<IValidacaoFluent, ValidacaoFluent>();
            service.TryAddTransient<IProjetoService, ProjetoService>();
            service.TryAddTransient<IVariavelService, VariavelService>();
            service.TryAddTransient<IValoresVariavelService, ValoresVariavelService>();
            #endregion

            #region Services front
            service.TryAddScoped<InjectorServiceBaseApresentation>();
            service.TryAddTransient<ValidatorService>();

            #region Projeto
            service.TryAddTransient<ProjetoServiceAplicacaoAdd>();
            service.TryAddTransient<ProjetoServiceAplicacaoGet>();
            service.TryAddSingleton<ProjetoSelecionadoServiceAplicacao>();
            #endregion

            #region Variavel
            service.TryAddTransient<VariavelServiceAplicacaoAdd>();
            service.TryAddTransient<VariavelServiceAplicacaoGet>();
            service.TryAddTransient<VariavelServiceAplicacaoRemove>();
            #endregion

            #endregion

            return service;
        }
    }
}
