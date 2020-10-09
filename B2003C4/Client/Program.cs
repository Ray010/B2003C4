using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Authorization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Extensions.Options;
using B2003C4.Client;

namespace B2003C4
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();

            builder.Services.AddOidcAuthentication(Options =>
            {
                builder.Configuration.Bind("Local", Options.ProviderOptions);
            });
            builder.Services.AddSingleton(p => p.GetRequiredService<IConfiguration>().Get<AppSettings>());

            await builder.Build().RunAsync();
        }

    }
    public class AppSettings
    {
        public string IPAddress { get; set; }
    }

}
