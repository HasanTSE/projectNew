using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectNew.Models
{

    [Table("EmpNation")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Nationality")]
        [StringLength(200)]
        public string NationName { get; set; }

        [Display(Name = "Is active")]
        public bool IsActive { get; set; }
    }
}
