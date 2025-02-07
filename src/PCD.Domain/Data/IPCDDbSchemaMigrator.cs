using System.Threading.Tasks;

namespace PCD.Data;

public interface IPCDDbSchemaMigrator
{
    Task MigrateAsync();
}
