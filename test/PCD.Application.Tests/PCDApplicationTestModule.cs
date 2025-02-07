using Volo.Abp.Modularity;

namespace PCD;

[DependsOn(
    typeof(PCDApplicationModule),
    typeof(PCDDomainTestModule)
)]
public class PCDApplicationTestModule : AbpModule
{

}
