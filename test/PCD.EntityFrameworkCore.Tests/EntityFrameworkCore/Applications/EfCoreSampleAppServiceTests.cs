using PCD.Samples;
using Xunit;

namespace PCD.EntityFrameworkCore.Applications;

[Collection(PCDTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<PCDEntityFrameworkCoreTestModule>
{

}
