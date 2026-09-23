using Acme.BookingManagememtSystem4.Samples;
using Xunit;

namespace Acme.BookingManagememtSystem4.EntityFrameworkCore.Domains;

[Collection(BookingManagememtSystem4TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BookingManagememtSystem4EntityFrameworkCoreTestModule>
{

}
