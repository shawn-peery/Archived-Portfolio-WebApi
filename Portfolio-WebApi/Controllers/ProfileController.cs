using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApi.Controllers
{
    public class ProfileController : Controller
    {
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult<string> Profile()
        {
            return "Test";
        }
    }
}
