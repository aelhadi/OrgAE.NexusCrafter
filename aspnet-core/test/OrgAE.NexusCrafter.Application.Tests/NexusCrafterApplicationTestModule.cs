using Volo.Abp.Modularity;

namespace OrgAE.NexusCrafter;

[DependsOn(
    typeof(NexusCrafterApplicationModule),
    typeof(NexusCrafterDomainTestModule)
)]
public class NexusCrafterApplicationTestModule : AbpModule
{

}
