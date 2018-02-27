using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace RS.School.Authorization
{
    public class SchoolAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //模块最基本权限
            context.CreatePermission(PermissionNames.School, L("School"));
            
           
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, SchoolConsts.LocalizationSourceName);
        }
    }
}
