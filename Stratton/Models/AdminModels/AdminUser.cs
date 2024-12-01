using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class AdminUser
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string  AdminUserName { get; set; }
        [MaxLength(50)]
        public string AdminUserEmail { get; set; }
        [MaxLength(50)]
        public string AdminUserPassword { get; set; }
        [MaxLength(20)]
        public string? Position { get; set; }
    }
}
