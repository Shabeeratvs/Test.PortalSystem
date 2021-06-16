using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Test.PortalSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(PortalSystemEntityFrameworkCoreModule)
        )]
    public class PortalSystemEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<PortalSystemMigrationsDbContext>();
        }
    }
}
