using OrgAE.NexusCrafter.Samples;
using Xunit;

namespace OrgAE.NexusCrafter.EntityFrameworkCore.Domains;

[Collection(NexusCrafterTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NexusCrafterEntityFrameworkCoreTestModule>
{

}
