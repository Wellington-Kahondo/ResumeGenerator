using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ResumeGenerator.Configuration;
using ResumeGenerator.EntityFrameworkCore;
using ResumeGenerator.Migrator.DependencyInjection;

namespace ResumeGenerator.Migrator
{
    [DependsOn(typeof(ResumeGeneratorEntityFrameworkModule))]
    public class ResumeGeneratorMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ResumeGeneratorMigratorModule(ResumeGeneratorEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ResumeGeneratorMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ResumeGeneratorConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(ResumeGeneratorMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
