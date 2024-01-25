using Xunit;

namespace OrgAE.NexusCrafter.EntityFrameworkCore;

[CollectionDefinition(NexusCrafterTestConsts.CollectionDefinitionName)]
public class NexusCrafterEntityFrameworkCoreCollection : ICollectionFixture<NexusCrafterEntityFrameworkCoreFixture>
{

}
