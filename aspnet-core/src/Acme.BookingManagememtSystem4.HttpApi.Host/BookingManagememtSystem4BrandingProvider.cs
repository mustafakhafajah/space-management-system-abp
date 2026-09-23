using Microsoft.Extensions.Localization;
using Acme.BookingManagememtSystem4.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Acme.BookingManagememtSystem4;

[Dependency(ReplaceServices = true)]
public class BookingManagememtSystem4BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<BookingManagememtSystem4Resource> _localizer;

    public BookingManagememtSystem4BrandingProvider(IStringLocalizer<BookingManagememtSystem4Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
