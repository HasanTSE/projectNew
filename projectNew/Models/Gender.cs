using System.ComponentModel.DataAnnotations;

namespace projectNew.Models
{
    public class Gender
    {
        public int Id { get; set; }


        [StringLength(100)]
        public string GenderName { get; set; }
    }
}
