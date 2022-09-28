using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectNew.Models
{
    [Table("EmpInfo")]
    public class Info
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string? Name { get; set; }

        public int? NationId { get; set; }

        [ForeignKey("NationId")]

        public Nation? Nation  { get; set; }

        public bool IsActive { get; set; }

    }
}
