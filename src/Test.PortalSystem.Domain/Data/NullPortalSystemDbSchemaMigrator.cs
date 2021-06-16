using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Test.PortalSystem.Data
{
    /* This is used if database provider does't define
     * IPortalSystemDbSchemaMigrator implementation.
     */
    public class NullPortalSystemDbSchemaMigrator : IPortalSystemDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}