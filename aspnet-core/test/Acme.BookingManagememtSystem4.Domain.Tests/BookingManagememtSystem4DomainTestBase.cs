using Volo.Abp.Modularity;

namespace Acme.BookingManagememtSystem4;

/* Inherit from this class for your domain layer tests. */
public abstract class BookingManagememtSystem4DomainTestBase<TStartupModule> : BookingManagememtSystem4TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
