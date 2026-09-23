using Acme.BookingManagememtSystem4.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.BookingManagememtSystem4.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookingManagememtSystem4EntityFrameworkCoreModule),
    typeof(BookingManagememtSystem4ApplicationContractsModule)
    )]
public class BookingManagememtSystem4DbMigratorModule : AbpModule
{
}
