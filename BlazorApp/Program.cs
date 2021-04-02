using Blazored.Toast;
using BlazorApp.Configuracoes;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddAutoMapper(typeof(Program).Assembly);
            builder.Services.AddBlazoredToast();
            builder.Services.AddDataBaseInMemory();
            builder.Services.AddInjecaoDependencia();
            await builder.Build().RunAsync();
        }
    }
}
