using System.ComponentModel.DataAnnotations;
 

namespace projectNew.Models
{
    public class Desig
    {
        [Key]
        public int Id { get; set; }
       
        [StringLength(200)]
        public string Designation { get; set; }

        [Display(Name = "Is active")]
        public bool IsActive { get; set; }
    }
}
