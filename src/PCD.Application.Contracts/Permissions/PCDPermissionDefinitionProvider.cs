using PCD.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace PCD.Permissions;

public class PCDPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PCDPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PCDPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PCDResource>(name);
    }
}
