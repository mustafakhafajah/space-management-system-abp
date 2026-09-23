using Acme.BookingManagememtSystem4.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookingManagememtSystem4.Permissions;

public class BookingManagememtSystem4PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BookingManagememtSystem4Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BookingManagememtSystem4Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BookingManagememtSystem4Resource>(name);
    }
}
