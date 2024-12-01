using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class ContactUs
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string ContactEmail { get; set; }

        [MaxLength(50)]
        public string ContactDiscord { get; set; }
    }
}
