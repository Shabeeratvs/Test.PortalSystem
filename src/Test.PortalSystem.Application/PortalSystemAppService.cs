using System;
using System.Collections.Generic;
using System.Text;
using Test.PortalSystem.Localization;
using Volo.Abp.Application.Services;

namespace Test.PortalSystem
{
    /* Inherit your application services from this class.
     */
    public abstract class PortalSystemAppService : ApplicationService
    {
        protected PortalSystemAppService()
        {
            LocalizationResource = typeof(PortalSystemResource);
        }
    }
}
