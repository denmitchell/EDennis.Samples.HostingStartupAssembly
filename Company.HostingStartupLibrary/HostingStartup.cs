using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Company.HostingStartupLibrary.HostingStartup))]

namespace Company.HostingStartupLibrary
{
    public class HostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.Configure<InjectedTimeOptions>(context.Configuration.GetSection("InjectedTimeOptions"));
                services.AddSingleton<IInjectedTime, InjectedTime>();            
            });
        }
    }
}
