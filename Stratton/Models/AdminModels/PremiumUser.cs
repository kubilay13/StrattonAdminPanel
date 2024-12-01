using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class PremiumUser
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string PremiumUserName { get; set; }
        [MaxLength(50)]
        public string PremiumUserEmail { get; set; }
        [MaxLength(50)]
        public string PremiumUserPassword { get; set; }
        [MaxLength(20)]
        public string? Position { get; set; }
    }
}
