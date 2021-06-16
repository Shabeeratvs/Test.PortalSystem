using Test.PortalSystem.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Test.PortalSystem.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class PortalSystemPageModel : AbpPageModel
    {
        protected PortalSystemPageModel()
        {
            LocalizationResourceType = typeof(PortalSystemResource);
        }
    }
}