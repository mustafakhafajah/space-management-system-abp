using Acme.BookingManagememtSystem4.Samples;
using Xunit;

namespace Acme.BookingManagememtSystem4.EntityFrameworkCore.Applications;

[Collection(BookingManagememtSystem4TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookingManagememtSystem4EntityFrameworkCoreTestModule>
{

}
