using OrgAE.NexusCrafter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OrgAE.NexusCrafter.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NexusCrafterController : AbpControllerBase
{
    protected NexusCrafterController()
    {
        LocalizationResource = typeof(NexusCrafterResource);
    }
}
