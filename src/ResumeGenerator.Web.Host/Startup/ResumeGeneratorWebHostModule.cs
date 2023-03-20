using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ResumeGenerator.Configuration;

namespace ResumeGenerator.Web.Host.Startup
{
    [DependsOn(
       typeof(ResumeGeneratorWebCoreModule))]
    public class ResumeGeneratorWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ResumeGeneratorWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ResumeGeneratorWebHostModule).GetAssembly());
        }
    }
}
