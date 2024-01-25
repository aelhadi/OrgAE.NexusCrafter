using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrgAE.NexusCrafter.Data;
using Volo.Abp.DependencyInjection;

namespace OrgAE.NexusCrafter.EntityFrameworkCore;

public class EntityFrameworkCoreNexusCrafterDbSchemaMigrator
    : INexusCrafterDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNexusCrafterDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the NexusCrafterDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NexusCrafterDbContext>()
            .Database
            .MigrateAsync();
    }
}
