using Volo.Abp.Modularity;

namespace Acme.BookingManagememtSystem4;

[DependsOn(
    typeof(BookingManagememtSystem4ApplicationModule),
    typeof(BookingManagememtSystem4DomainTestModule)
)]
public class BookingManagememtSystem4ApplicationTestModule : AbpModule
{

}
