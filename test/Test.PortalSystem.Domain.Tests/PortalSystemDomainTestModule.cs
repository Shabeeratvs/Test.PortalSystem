using Test.PortalSystem.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Test.PortalSystem
{
    [DependsOn(
        typeof(PortalSystemEntityFrameworkCoreTestModule)
        )]
    public class PortalSystemDomainTestModule : AbpModule
    {

    }
}