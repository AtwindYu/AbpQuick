using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RS.School.EntityFrameworkCore
{
    public class SchoolDbContext : AbpDbContext
    {
        
        
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }



    }
}
