using System.ComponentModel.DataAnnotations;
 

namespace projectNew.Models
{
    public class Dept
    {
        [Key]
        public int Id { get; set; }
     
        [StringLength(200)]
        public string Department { get; set; }

        [Display(Name = "Is active")]
        public bool IsActive { get; set; }
    }
}
