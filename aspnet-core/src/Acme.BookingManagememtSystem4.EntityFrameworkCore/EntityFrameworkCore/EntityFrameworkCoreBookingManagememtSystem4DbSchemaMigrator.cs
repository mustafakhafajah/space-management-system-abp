using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Acme.BookingManagememtSystem4.Data;
using Volo.Abp.DependencyInjection;

namespace Acme.BookingManagememtSystem4.EntityFrameworkCore;

public class EntityFrameworkCoreBookingManagememtSystem4DbSchemaMigrator
    : IBookingManagememtSystem4DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBookingManagememtSystem4DbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the BookingManagememtSystem4DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BookingManagememtSystem4DbContext>()
            .Database
            .MigrateAsync();
    }
}
