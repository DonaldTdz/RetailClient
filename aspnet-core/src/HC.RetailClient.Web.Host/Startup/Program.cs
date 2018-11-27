using ElectronNET.API;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace HC.RetailClient.Web.Host.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            //return WebHost.CreateDefaultBuilder(args)
            //    .UseStartup<Startup>()
            //    .Build();
           
            return WebHost.CreateDefaultBuilder(args)
               .UseElectron(args)
               .UseStartup<Startup>()
               .Build();
        }
    }
}
