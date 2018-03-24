using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Learning_phone.Configuration;

namespace Learning_phone.Web.Host.Startup
{
    [DependsOn(
       typeof(Learning_phoneWebCoreModule))]
    public class Learning_phoneWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Learning_phoneWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Learning_phoneWebHostModule).GetAssembly());
        }
    }
}
