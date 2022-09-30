using System.ComponentModel.DataAnnotations;

namespace projectNew.Models
{
    public class PreDistrict
    {
        public int Id { get; set; }


        [StringLength(100)]
        public string PresentDistrict { get; set; }
    }
}
