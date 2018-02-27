using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RS.Configuration;
using RS.Web;

namespace RS.School.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class SchoolDbContextFactory : IDesignTimeDbContextFactory<SchoolDbContext>
    {
        public SchoolDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SchoolDbContext>();
            var configuration = AppConfiguration.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            SchoolDbContextConfigurer.Configure(builder, configuration.GetConnectionString(SchoolConsts.ConnectionStringName));

            return new SchoolDbContext(builder.Options);
        }
    }
}
