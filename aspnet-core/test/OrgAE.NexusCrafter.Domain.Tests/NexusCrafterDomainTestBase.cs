using Volo.Abp.Modularity;

namespace OrgAE.NexusCrafter;

/* Inherit from this class for your domain layer tests. */
public abstract class NexusCrafterDomainTestBase<TStartupModule> : NexusCrafterTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
