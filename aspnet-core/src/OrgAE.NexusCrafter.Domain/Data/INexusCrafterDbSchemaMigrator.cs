using System.Threading.Tasks;

namespace OrgAE.NexusCrafter.Data;

public interface INexusCrafterDbSchemaMigrator
{
    Task MigrateAsync();
}
