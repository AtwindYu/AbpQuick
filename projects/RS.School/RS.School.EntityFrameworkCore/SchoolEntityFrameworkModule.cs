using Abp.Modules;
using Abp.Zero.EntityFrameworkCore;

namespace RS.School
{
    [DependsOn(
        typeof(SchoolDomainModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class SchoolEntityFrameworkModule : AbpModule
    {
    }
}
