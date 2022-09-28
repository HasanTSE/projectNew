using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectNew.Models
{

    [Table("EmpNation")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(200)]
        public string NationName { get; set; }

        public bool IsActive { get; set; }
    }
}
