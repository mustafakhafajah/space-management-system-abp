using Volo.Abp.Modularity;

namespace Acme.BookingManagememtSystem4;

[DependsOn(
    typeof(BookingManagememtSystem4DomainModule),
    typeof(BookingManagememtSystem4TestBaseModule)
)]
public class BookingManagememtSystem4DomainTestModule : AbpModule
{

}
