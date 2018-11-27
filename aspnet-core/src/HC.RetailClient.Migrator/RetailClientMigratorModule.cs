using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HC.RetailClient.Configuration;
using HC.RetailClient.EntityFrameworkCore;
using HC.RetailClient.Migrator.DependencyInjection;

namespace HC.RetailClient.Migrator
{
    [DependsOn(typeof(RetailClientEntityFrameworkModule))]
    public class RetailClientMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public RetailClientMigratorModule(RetailClientEntityFrameworkModule RetailClientEntityFrameworkModule)
        {
            RetailClientEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(RetailClientMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                RetailClientConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RetailClientMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
