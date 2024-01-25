using OrgAE.NexusCrafter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace OrgAE.NexusCrafter.Permissions;

public class NexusCrafterPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NexusCrafterPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NexusCrafterPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NexusCrafterResource>(name);
    }
}
