using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ResumeGenerator.Authorization;

namespace ResumeGenerator
{
    [DependsOn(
        typeof(ResumeGeneratorCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ResumeGeneratorApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ResumeGeneratorAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ResumeGeneratorApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
