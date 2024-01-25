using Volo.Abp.Modularity;

namespace OrgAE.NexusCrafter;

public abstract class NexusCrafterApplicationTestBase<TStartupModule> : NexusCrafterTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
