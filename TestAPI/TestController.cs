using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilityLibraries;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public bool TestMethod([FromQuery]string param="World")
        {
            return param.StartsWithUpper();
        }

        public string Get()
        {
            return "Get Method";
        }
    }
}
