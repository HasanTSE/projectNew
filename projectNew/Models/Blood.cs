using System.ComponentModel.DataAnnotations;

namespace projectNew.Models
{
    public class Blood
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string BloodGroup { get; set; }
    }
}
