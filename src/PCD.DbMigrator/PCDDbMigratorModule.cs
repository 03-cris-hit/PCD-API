using PCD.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PCD.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PCDEntityFrameworkCoreModule),
    typeof(PCDApplicationContractsModule)
    )]
public class PCDDbMigratorModule : AbpModule
{
}
