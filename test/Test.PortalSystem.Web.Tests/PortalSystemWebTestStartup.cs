using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Test.PortalSystem
{
    public class PortalSystemWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<PortalSystemWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}