using Volo.Abp.Settings;

namespace OrgAE.NexusCrafter.Settings;

public class NexusCrafterSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NexusCrafterSettings.MySetting1));
    }
}
