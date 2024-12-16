using Microsoft.AspNetCore.Mvc;
using Stratton.Database;
using Stratton.Services.CryptoServices.TronServices;

namespace Stratton.Controllers
{
    public class CryptoWalletController : Controller
    {

        private readonly TronWalletServices _tronWalletServices;
        private readonly ApplicationDbContext _DbContext;
        public CryptoWalletController(TronWalletServices tronWalletServices,ApplicationDbContext applicationDbContext)
        {
            _DbContext = applicationDbContext;
            _tronWalletServices = tronWalletServices;

        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreateTronWallet()
        {
            var allwallets = _DbContext.TronWalletModelss.ToList();
            return View(allwallets);
        }

        //----------------- HTTP İSTEKLERİ -----------------
        [HttpPost]
        public async Task<IActionResult> CreateTronWallet(string generateWallet)
        {
            if (!string.IsNullOrEmpty(generateWallet))
            {
                var walletInfo = await _tronWalletServices.TronCreateWalletService();
                ViewData["WalletAddress"] = walletInfo;
            }
            return RedirectToAction("CreateTronWallet");
        }
    }
}
