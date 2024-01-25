using System;
using System.Collections.Generic;
using System.Text;
using OrgAE.NexusCrafter.Localization;
using Volo.Abp.Application.Services;

namespace OrgAE.NexusCrafter;

/* Inherit your application services from this class.
 */
public abstract class NexusCrafterAppService : ApplicationService
{
    protected NexusCrafterAppService()
    {
        LocalizationResource = typeof(NexusCrafterResource);
    }
}
