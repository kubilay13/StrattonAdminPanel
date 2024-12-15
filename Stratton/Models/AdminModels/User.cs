using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string UserEmail { get; set; }
        [MaxLength(50)]
        public string UserPassword { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
