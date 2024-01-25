using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace OrgAE.NexusCrafter;

[Dependency(ReplaceServices = true)]
public class NexusCrafterBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NexusCrafter";
}
