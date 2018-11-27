using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HC.RetailClient.Authorization;

namespace HC.RetailClient
{
    [DependsOn(
        typeof(RetailClientCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RetailClientApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RetailClientAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RetailClientApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
