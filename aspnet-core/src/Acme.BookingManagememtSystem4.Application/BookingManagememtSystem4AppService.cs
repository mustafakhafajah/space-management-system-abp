using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookingManagememtSystem4.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookingManagememtSystem4;

/* Inherit your application services from this class.
 */
public abstract class BookingManagememtSystem4AppService : ApplicationService
{
    protected BookingManagememtSystem4AppService()
    {
        LocalizationResource = typeof(BookingManagememtSystem4Resource);
    }
}
