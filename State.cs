using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cascading.Models
{
    public class State
    {
        [Key]
        public int StateID { get; set; }

        [Required]
        [StringLength(100)]
        public string StateName { get; set; }

        [ForeignKey("Country")]
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}
