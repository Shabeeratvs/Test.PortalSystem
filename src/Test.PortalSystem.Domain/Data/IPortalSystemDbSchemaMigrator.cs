using System.Threading.Tasks;

namespace Test.PortalSystem.Data
{
    public interface IPortalSystemDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
