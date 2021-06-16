using Test.PortalSystem.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Test.PortalSystem.Permissions
{
    public class PortalSystemPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(PortalSystemPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(PortalSystemPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<PortalSystemResource>(name);
        }
    }
}
