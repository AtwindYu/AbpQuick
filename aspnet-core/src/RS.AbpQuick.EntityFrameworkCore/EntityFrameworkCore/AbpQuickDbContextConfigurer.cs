using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RS.AbpQuick.EntityFrameworkCore
{
    public static class AbpQuickDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpQuickDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpQuickDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
