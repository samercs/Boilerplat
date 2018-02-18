﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SamerCs.Authorization;

namespace SamerCs
{
    [DependsOn(
        typeof(SamerCsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SamerCsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SamerCsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SamerCsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
