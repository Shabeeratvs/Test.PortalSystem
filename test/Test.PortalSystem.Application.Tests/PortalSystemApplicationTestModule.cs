using Volo.Abp.Modularity;

namespace Test.PortalSystem
{
    [DependsOn(
        typeof(PortalSystemApplicationModule),
        typeof(PortalSystemDomainTestModule)
        )]
    public class PortalSystemApplicationTestModule : AbpModule
    {

    }
}