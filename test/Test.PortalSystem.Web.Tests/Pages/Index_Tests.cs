using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Test.PortalSystem.Pages
{
    public class Index_Tests : PortalSystemWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
