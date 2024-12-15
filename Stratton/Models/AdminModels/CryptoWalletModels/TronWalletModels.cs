namespace Stratton.Models.AdminModels.CryptoWalletModels
{
    public class TronWalletModels
    {
        public int Id { get; set; }

        public string WalletAdress { get; set; }

        public string PrivateKey { get; set; }

        public decimal Amount { get; set; }

        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
