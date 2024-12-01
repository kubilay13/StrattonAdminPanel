using System.ComponentModel.DataAnnotations;

namespace Stratton.Models.AdminModels
{
    public class AboutUs
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Explanation { get; set; }
    }
}
