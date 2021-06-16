using Test.PortalSystem.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Test.PortalSystem.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(PortalSystemEntityFrameworkCoreDbMigrationsModule),
        typeof(PortalSystemApplicationContractsModule)
        )]
    public class PortalSystemDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
