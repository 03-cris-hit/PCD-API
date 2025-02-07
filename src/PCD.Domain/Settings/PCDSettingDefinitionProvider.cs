using Volo.Abp.Settings;

namespace PCD.Settings;

public class PCDSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PCDSettings.MySetting1));
    }
}
