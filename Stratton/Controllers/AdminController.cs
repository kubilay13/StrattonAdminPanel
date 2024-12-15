using Microsoft.AspNetCore.Mvc;
using Stratton.Database;
using Stratton.Models.AdminModels;

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
        public IActionResult Users()
        {
            int users = _Context.Users.Count();
            ViewBag.Users = users;
            var allusers = _Context.Users.ToList();
            return View(allusers);
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


        public IActionResult AdminVideoAdd()
        {
            return View();
        }

        public IActionResult AddUser()
        {   
            return View();
        }

   
        //-----------------------HTTP İSTEKLERİ-----------------------

        [HttpPost]
        public IActionResult AddUserMethot(PremiumUser premiumUser)
        {

            _Context.premiumUsers.Add(premiumUser);
            _Context.SaveChanges();

            return RedirectToAction("PremiumUser");
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
            else if (userType == "user")
            {
                var user = _Context.Users.Find(id);
                if (user != null)
                {
                    _Context.Users.Remove(user);
                    _Context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditPremiumUser(int id, string PremiumUserName, string PremiumUserEmail, string PremiumUserPassword, string Position) 
        {
            var premiumuseredit = _Context.premiumUsers.Find(id);
            if (premiumuseredit != null)
            {
                premiumuseredit.PremiumUserName = PremiumUserName;
                premiumuseredit.PremiumUserEmail = PremiumUserEmail;
                premiumuseredit.PremiumUserPassword = PremiumUserPassword;
                premiumuseredit.Position = Position;

                _Context.SaveChanges();
            }
            return RedirectToAction("PremiumUser");
        }

        [HttpPost]
        public IActionResult EditModeratorUser(int id,string ModeratorUserName,string ModeratorUserEmail,string ModeratorUserPassword, string Position)
        {
            var moderatoruseredit =_Context.moderatorUsers.Find(id);
            if (moderatoruseredit != null)
            {
                moderatoruseredit.ModeratorUserName = ModeratorUserName;
                moderatoruseredit.ModeratorUserEmail = ModeratorUserEmail;
                moderatoruseredit.ModeratorUserPassword= ModeratorUserPassword;
                moderatoruseredit.Position = Position;  
                _Context.SaveChanges();
            }
            return RedirectToAction("ModeratorUser");
        }

        [HttpPost]
        public IActionResult EditUser(int id, string UserName, string UserEmail, string UserPassword)
        {
            var useredit = _Context.Users.Find(id);
            if (useredit != null)
            {
                useredit.UserName = UserName;
                useredit.UserEmail = UserEmail;
                useredit.UserPassword = UserPassword;
                _Context.SaveChanges();
            }
            return RedirectToAction("Users");
        }
    }
}
