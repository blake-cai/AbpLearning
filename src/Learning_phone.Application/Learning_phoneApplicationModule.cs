using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Learning_phone.Authorization;

namespace Learning_phone
{
    [DependsOn(
        typeof(Learning_phoneCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Learning_phoneApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Learning_phoneAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Learning_phoneApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
