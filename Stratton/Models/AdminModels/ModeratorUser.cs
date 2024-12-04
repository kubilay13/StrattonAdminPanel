using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class ModeratorUser
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string ModeratorUserName { get; set; }
        [MaxLength(50)]
        public string ModeratorUserEmail { get; set; }
        [MaxLength(50)]
        public string ModeratorUserPassword { get; set; }
        [MaxLength(20)]
        public string? Position { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    }
}
