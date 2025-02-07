using Xunit;

namespace PCD.EntityFrameworkCore;

[CollectionDefinition(PCDTestConsts.CollectionDefinitionName)]
public class PCDEntityFrameworkCoreCollection : ICollectionFixture<PCDEntityFrameworkCoreFixture>
{

}
