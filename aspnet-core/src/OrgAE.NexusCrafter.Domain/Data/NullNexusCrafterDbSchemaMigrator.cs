using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OrgAE.NexusCrafter.Data;

/* This is used if database provider does't define
 * INexusCrafterDbSchemaMigrator implementation.
 */
public class NullNexusCrafterDbSchemaMigrator : INexusCrafterDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
