using Acme.BookingManagememtSystem4.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookingManagememtSystem4.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BookingManagememtSystem4Controller : AbpControllerBase
{
    protected BookingManagememtSystem4Controller()
    {
        LocalizationResource = typeof(BookingManagememtSystem4Resource);
    }
}
