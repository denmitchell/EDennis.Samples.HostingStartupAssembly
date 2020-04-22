using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;


//SETTING TO USE IWebHostBuilder FROM THIS EXTERNAL STARTUP
[assembly: HostingStartup(typeof(Company.HostingStartupLibrary.HostingStartup))]

namespace Company.HostingStartupLibrary
{
    public class HostingStartup : IHostingStartup //REQUIRED INTERFACE
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                
                //services.Configure for DI'd options
                var options = context.Configuration.GetSection("InjectedTimeOptions");
                services.Configure<InjectedTimeOptions>(options);

                //check ConfigurationSection.Bind for non-DI'd options
                //var ito = new InjectedTimeOptions();
                //options.Bind(ito);

                //configure singleton
                services.AddSingleton<IInjectedTime,InjectedTime>();
            });            
        }
    }
}
