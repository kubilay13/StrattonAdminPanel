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
            int toplamadmin = _Context.AdminUsers.Count();
            int toplammoderator = _Context.moderatorUsers.Count();
            int premiumuser = _Context.premiumUsers.Count();
            int toplamuser = toplamadmin + toplammoderator + premiumuser;
            ViewBag.ToplamUser = toplamuser;
            ViewBag.PremiumUser = premiumuser;
            return View(toplamuser);
        }
        public IActionResult AdminUsers()
        {
            int adminusers = _Context.AdminUsers.Count(); 
            ViewBag.AdminUsers = adminusers;
            var adminuser = _Context.AdminUsers.ToList();
            return View(adminuser);
        }

        public IActionResult ModeratorUser()
        {
            int moderatorusers = _Context.moderatorUsers.Count();
            ViewBag.ModeratorUsers = moderatorusers;
            var moderatoruser = _Context.moderatorUsers.ToList();
            return View(moderatoruser);
        }

        public IActionResult PremiumUser()
        {
            int premiumusers = _Context.premiumUsers.Count();
            ViewBag.PremiumUsers = premiumusers;
            var premiumuser = _Context.premiumUsers.ToList();
            return View(premiumuser);
        }

        public IActionResult AdminProfile()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Delete(int id, string userType)
        {
            if (userType == "moderator")
            {
                var moderatorUser = _Context.moderatorUsers.Find(id);
                if (moderatorUser != null)
                {
                    _Context.moderatorUsers.Remove(moderatorUser);
                    _Context.SaveChanges();
                }
            }
            else if (userType == "premium")
            {
                var premiumUser = _Context.premiumUsers.Find(id);
                if (premiumUser != null)
                {
                    _Context.premiumUsers.Remove(premiumUser);
                    _Context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

    }
}
