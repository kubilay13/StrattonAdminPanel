using Microsoft.AspNetCore.Mvc;
using Stratton.Database;

namespace Stratton.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _Context;
        
        public AdminController(ApplicationDbContext applicationDbContext)
        {
            _Context = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminUsers()
        {
            var adminuser = _Context.AdminUsers.ToList();
            return View(adminuser);
        }

        public IActionResult ModeratorUser()
        {
            var moderatoruser = _Context.moderatorUsers.ToList();
            return View(moderatoruser);
        }

        public IActionResult PremiumUser()
        {
            var premiumuser = _Context.premiumUsers.ToList();
            return View(premiumuser);
        }
    }
}
