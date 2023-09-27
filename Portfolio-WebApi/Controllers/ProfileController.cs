using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApi.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public ActionResult<string> Profile()
        {
            return "Test";
        }
    }
}
