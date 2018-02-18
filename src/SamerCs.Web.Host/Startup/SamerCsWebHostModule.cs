using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SamerCs.Configuration;

namespace SamerCs.Web.Host.Startup
{
    [DependsOn(
       typeof(SamerCsWebCoreModule))]
    public class SamerCsWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SamerCsWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SamerCsWebHostModule).GetAssembly());
        }
    }
}
