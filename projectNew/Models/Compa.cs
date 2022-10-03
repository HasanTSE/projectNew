using System.ComponentModel.DataAnnotations;

namespace projectNew.Models
{
    public class Compa
    {
        [Key]
        public int Id { get; set; }
         
 
        [StringLength(200)]
        public string Company { get; set; }

        [Display(Name = "Is active")]
        public bool IsActive { get; set; }
    }
}
