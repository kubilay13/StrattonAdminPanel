using Stratton.Database;
using Stratton.Models.AdminModels.CryptoWalletModels;
using TronNet;

namespace Stratton.Services.CryptoServices.TronServices
{
    
    public class TronWalletServices
    {
        private readonly ApplicationDbContext _Context;

        public TronWalletServices(ApplicationDbContext applicationDbContext)
        {
            _Context = applicationDbContext;
        }

        public async Task<string> TronCreateWalletService()
        {
            var key = TronECKey.GenerateKey(TronNetwork.MainNet);
            var address = key.GetPublicAddress();
            var privatekey= key.GetPrivateKey();
            var tronScanLink = $"https://tronscan.org/#/address/{address}";

            var wallet = new TronWalletModels
            {
                WalletAdress = address,
                PrivateKey = privatekey,
                Amount = 0,
                CreateDate = DateTime.UtcNow,
            };

            if (_Context.TronWalletModelss != null)
            {
                _Context.TronWalletModelss.Add(wallet);
                await _Context.SaveChangesAsync();
            }
            Console.WriteLine($"Cüzdan Adresi: {address} , Private Key: {privatekey}");
            return $"{tronScanLink}<br>Private Key: {privatekey}";
        }
    }
}
