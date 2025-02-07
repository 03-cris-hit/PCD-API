using Volo.Abp.Modularity;

namespace PCD;

/* Inherit from this class for your domain layer tests. */
public abstract class PCDDomainTestBase<TStartupModule> : PCDTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
