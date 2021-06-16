using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Test.PortalSystem.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class PortalSystemMigrationsDbContextFactory : IDesignTimeDbContextFactory<PortalSystemMigrationsDbContext>
    {
        public PortalSystemMigrationsDbContext CreateDbContext(string[] args)
        {
            PortalSystemEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<PortalSystemMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new PortalSystemMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Test.PortalSystem.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
