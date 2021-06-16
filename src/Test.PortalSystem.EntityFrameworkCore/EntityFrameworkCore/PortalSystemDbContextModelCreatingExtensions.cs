using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Test.PortalSystem.EntityFrameworkCore
{
    public static class PortalSystemDbContextModelCreatingExtensions
    {
        public static void ConfigurePortalSystem(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(PortalSystemConsts.DbTablePrefix + "YourEntities", PortalSystemConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}