using Abp.EntityFrameworkCore;
using Castle.Core.Logging;
using Microsoft.EntityFrameworkCore;
using RS.School.Domain.Students;

namespace RS.School.EntityFrameworkCore
{
    public class SchoolDbContext : AbpDbContext
    {
        
        
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
            
        }



        public DbSet<Student> Students { get; set; }
    }
}
