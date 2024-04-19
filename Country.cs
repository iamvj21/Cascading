using System.ComponentModel.DataAnnotations;

namespace Cascading.Models
{
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

    }
}
