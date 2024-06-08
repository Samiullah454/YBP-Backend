using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HCA.EntityFrameworkCore;
using HCA.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HCA.Web.Tests
{
    [DependsOn(
        typeof(HCAWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HCAWebTestModule : AbpModule
    {
        public HCAWebTestModule(HCAEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HCAWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HCAWebMvcModule).Assembly);
        }
    }
}