using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Test.PortalSystem.Web
{
    [Dependency(ReplaceServices = true)]
    public class PortalSystemBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "PortalSystem";
    }
}
