using PCD.Samples;
using Xunit;

namespace PCD.EntityFrameworkCore.Domains;

[Collection(PCDTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<PCDEntityFrameworkCoreTestModule>
{

}
