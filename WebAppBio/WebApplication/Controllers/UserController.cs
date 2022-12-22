using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bio()
        {
            return View();
        }
        public IActionResult Pol()
        {
            return View();
        }
    }
}
