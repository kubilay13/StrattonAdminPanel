using Microsoft.AspNetCore.Mvc;

namespace Stratton.Controllers
{
    public class LoginSignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
            
        }
        public IActionResult executiveLogin()
        {
            return View();
        }
    }
}
