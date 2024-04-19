using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cascading.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        [Required]
        [StringLength(100)]
        public string CityName { get; set; }

        [ForeignKey("State")]
        public int StateID { get; set; }
        public State State { get; set; }

    }
}
