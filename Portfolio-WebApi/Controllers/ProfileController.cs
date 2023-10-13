using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio_WebApi.Controllers
{
    public class ProfileController : ControllerBase
    {
        [Authorize(Roles = Roles.ADMIN_ROLE)]

        [HttpGet]
        public ActionResult<string> Profile()
        {
            return "Test";
        }
    }
}
