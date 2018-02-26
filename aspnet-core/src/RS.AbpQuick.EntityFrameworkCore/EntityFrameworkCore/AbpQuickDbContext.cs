using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RS.AbpQuick.Authorization.Roles;
using RS.AbpQuick.Authorization.Users;
using RS.AbpQuick.MultiTenancy;

namespace RS.AbpQuick.EntityFrameworkCore
{
    public class AbpQuickDbContext : AbpZeroDbContext<Tenant, Role, User, AbpQuickDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AbpQuickDbContext(DbContextOptions<AbpQuickDbContext> options)
            : base(options)
        {
        }
    }
}
