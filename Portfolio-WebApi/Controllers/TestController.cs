using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApi.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public string Test()
        {
            return "Test String";
        }
    }
}
