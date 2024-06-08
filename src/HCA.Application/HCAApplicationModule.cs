using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HCA.Authorization;

namespace HCA
{
    [DependsOn(
        typeof(HCACoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HCAApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HCAAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HCAApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
