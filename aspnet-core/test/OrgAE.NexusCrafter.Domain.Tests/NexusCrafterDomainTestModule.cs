using Volo.Abp.Modularity;

namespace OrgAE.NexusCrafter;

[DependsOn(
    typeof(NexusCrafterDomainModule),
    typeof(NexusCrafterTestBaseModule)
)]
public class NexusCrafterDomainTestModule : AbpModule
{

}
