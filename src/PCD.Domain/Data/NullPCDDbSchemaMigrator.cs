using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PCD.Data;

/* This is used if database provider does't define
 * IPCDDbSchemaMigrator implementation.
 */
public class NullPCDDbSchemaMigrator : IPCDDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
