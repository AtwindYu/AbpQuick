using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RS.AbpQuick.Configuration;
using RS.AbpQuick.Web;

namespace RS.AbpQuick.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpQuickDbContextFactory : IDesignTimeDbContextFactory<AbpQuickDbContext>
    {
        public AbpQuickDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpQuickDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpQuickDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpQuickConsts.ConnectionStringName));

            return new AbpQuickDbContext(builder.Options);
        }
    }
}
