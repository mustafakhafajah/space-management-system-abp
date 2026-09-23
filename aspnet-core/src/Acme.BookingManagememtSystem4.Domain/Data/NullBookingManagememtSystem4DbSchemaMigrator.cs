using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.BookingManagememtSystem4.Data;

/* This is used if database provider does't define
 * IBookingManagememtSystem4DbSchemaMigrator implementation.
 */
public class NullBookingManagememtSystem4DbSchemaMigrator : IBookingManagememtSystem4DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
