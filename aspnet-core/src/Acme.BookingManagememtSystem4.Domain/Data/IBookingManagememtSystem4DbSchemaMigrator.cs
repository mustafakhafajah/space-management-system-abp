using System.Threading.Tasks;

namespace Acme.BookingManagememtSystem4.Data;

public interface IBookingManagememtSystem4DbSchemaMigrator
{
    Task MigrateAsync();
}
