using Volo.Abp.Modularity;

namespace PCD;

[DependsOn(
    typeof(PCDDomainModule),
    typeof(PCDTestBaseModule)
)]
public class PCDDomainTestModule : AbpModule
{

}
