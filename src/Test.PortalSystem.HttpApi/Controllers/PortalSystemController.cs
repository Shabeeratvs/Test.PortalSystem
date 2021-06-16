using Test.PortalSystem.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Test.PortalSystem.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class PortalSystemController : AbpController
    {
        protected PortalSystemController()
        {
            LocalizationResource = typeof(PortalSystemResource);
        }
    }
}