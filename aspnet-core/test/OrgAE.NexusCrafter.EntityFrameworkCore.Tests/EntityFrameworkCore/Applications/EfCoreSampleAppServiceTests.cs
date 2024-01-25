using OrgAE.NexusCrafter.Samples;
using Xunit;

namespace OrgAE.NexusCrafter.EntityFrameworkCore.Applications;

[Collection(NexusCrafterTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NexusCrafterEntityFrameworkCoreTestModule>
{

}
