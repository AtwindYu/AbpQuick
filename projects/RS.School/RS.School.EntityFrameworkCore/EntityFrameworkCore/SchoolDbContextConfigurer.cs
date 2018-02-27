using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RS.School.EntityFrameworkCore
{
    public static class SchoolDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SchoolDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SchoolDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
