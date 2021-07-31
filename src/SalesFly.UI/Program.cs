using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.LocalStorage;
using SalesFly.UI.Services;

namespace SalesFly.UI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var api_url = builder.Configuration["api_url"];
            builder.Services.AddHttpClient("BackendAPI", client => client.BaseAddress = new Uri(api_url));
            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("BackendAPI"));

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddScoped<IAeroportoService, AeroportoService>();
            
            await builder.Build().RunAsync();
        }
    }
}
