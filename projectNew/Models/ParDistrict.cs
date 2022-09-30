using System.ComponentModel.DataAnnotations;

namespace projectNew.Models
{
    public class ParDistrict
    {
        public int Id { get; set; }


        [StringLength(100)]
        public string ParmanentDistrict { get; set; }
    }
}
