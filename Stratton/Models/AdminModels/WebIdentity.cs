using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class WebIdentity
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(50)]
        public string Keywords { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(250)]
        public string LogoUrl { get; set; }

        [MaxLength(50)]
        public string Unvan { get; set; }
    }
}
