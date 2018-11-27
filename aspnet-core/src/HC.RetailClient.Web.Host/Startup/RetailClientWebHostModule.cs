using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HC.RetailClient.Configuration;

namespace HC.RetailClient.Web.Host.Startup
{
    [DependsOn(
       typeof(RetailClientWebCoreModule))]
    public class RetailClientWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RetailClientWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RetailClientWebHostModule).GetAssembly());
        }
    }
}
