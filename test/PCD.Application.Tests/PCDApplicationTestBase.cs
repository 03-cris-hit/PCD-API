using Volo.Abp.Modularity;

namespace PCD;

public abstract class PCDApplicationTestBase<TStartupModule> : PCDTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
