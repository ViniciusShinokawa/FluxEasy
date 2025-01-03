using Microsoft.AspNetCore.Mvc;

namespace FluxEasy.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
