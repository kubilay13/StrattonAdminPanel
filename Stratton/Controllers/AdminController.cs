using Microsoft.AspNetCore.Mvc;

namespace Stratton.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
