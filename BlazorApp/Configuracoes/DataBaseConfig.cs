using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositorio.Contexto;

namespace BlazorApp.Configuracoes
{
    public static class DataBaseConfig
    {
        public static IServiceCollection AddDataBaseInMemory(this IServiceCollection service)
        {
            service.AddDbContext<Context>(options => options.UseInMemoryDatabase("IA")
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            return service;
        }
    }
}
