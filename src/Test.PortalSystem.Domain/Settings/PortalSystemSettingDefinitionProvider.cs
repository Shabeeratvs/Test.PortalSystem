using Volo.Abp.Settings;

namespace Test.PortalSystem.Settings
{
    public class PortalSystemSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(PortalSystemSettings.MySetting1));
        }
    }
}
