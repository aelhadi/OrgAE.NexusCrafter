using OrgAE.NexusCrafter.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace OrgAE.NexusCrafter.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(NexusCrafterEntityFrameworkCoreModule),
    typeof(NexusCrafterApplicationContractsModule)
    )]
public class NexusCrafterDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "NexusCrafter:"; });
    }
}
