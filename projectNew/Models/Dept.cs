using System.ComponentModel.DataAnnotations;
 

namespace projectNew.Models
{
    public class Dept
    {
        [Key]
        public int Id { get; set; }
     
        [StringLength(200)]
        public string Department { get; set; }

        public bool IsActive { get; set; }
    }
}
