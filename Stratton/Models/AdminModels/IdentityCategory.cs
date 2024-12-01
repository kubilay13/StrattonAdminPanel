using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class IdentityCategory
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string Views { get; set; }

        [MaxLength(250)]
        public string PhotoURL { get; set; }

    }
}
