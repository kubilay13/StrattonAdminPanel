using Stratton.Database;
using TronNet;

namespace Stratton.Services.CryptoServices.TronServices
{
    public class TronWalletServices
    {
        public async Task<string> TronCreateWalletService()
        {
            var key = TronECKey.GenerateKey(TronNetwork.MainNet);
            var address = key.GetPublicAddress();
            var privatekey= key.GetPrivateKey();
            var tronScanLink = $"https://tronscan.org/#/address/{address}";
            Console.WriteLine($"Cüzdan Adresi: {address} , Private Key: {privatekey}");
            return $"{tronScanLink}<br>Private Key: {privatekey}";
        }
    }
}
