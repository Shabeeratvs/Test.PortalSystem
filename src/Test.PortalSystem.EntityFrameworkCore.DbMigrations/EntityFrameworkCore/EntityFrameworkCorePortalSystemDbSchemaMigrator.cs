using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Test.PortalSystem.Data;
using Volo.Abp.DependencyInjection;

namespace Test.PortalSystem.EntityFrameworkCore
{
    public class EntityFrameworkCorePortalSystemDbSchemaMigrator
        : IPortalSystemDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCorePortalSystemDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the PortalSystemMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<PortalSystemMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}