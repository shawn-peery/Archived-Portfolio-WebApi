using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApi.Controllers
{
    public class ProfileController : Controller
    {
        [Authorize(Roles = "Admin")]
        [Route("[controller]")]

        [HttpGet]
        public ActionResult<string> Profile()
        {
            return "Test";
        }
    }
}
