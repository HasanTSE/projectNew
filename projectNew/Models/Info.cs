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


        //Nationality table here
        public int? NationId { get; set; }

        [ForeignKey("NationId")]

        public Nation? Nation { get; set; }

        //Nationality table here stop

        //Gender table here

        public int? GenderId { get; set; }

        [ForeignKey("GenderId")]

        public Gender? Gender { get; set; }

        //Gender table close here

        //Present District table goes here
        public int? PresentDistrictId { get; set; }

        [ForeignKey("PresentDistrictId")]

        public PreDistrict? PresentDistrict { get; set; }

        //Present District table close here

        //Parmanent District table goes here
        public int? ParmanentDistrictId { get; set; }

        [ForeignKey("ParmanentDistrictId")]

        public ParDistrict? ParmanentDistrict { get; set; }
        //Parmanent District table close here

        //Blood Group table goes here
        public int? BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]

        public Blood? BloodGroup { get; set; }


        //Blood Group table close here

        //Designation Table Goes Here
        public int? DesignationId { get; set; }

        [ForeignKey("DesignationId")]

        public Desig? Designation { get; set; }

        //Designation Table Close Here

        //Company Table Goes Here
        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]

        public Compa? Company { get; set; }
        //Company Table Close Here

        //Department Table Goes Here
        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]

        public Dept? Department { get; set; }
        //Department Table Close Here


        /// <summary>
        /// ///////
        /// </summary>
        [StringLength(200)]
        public string? NameBn { get; set; }

        [StringLength(200)]
        public string? FathersName { get; set; }

        [StringLength(200)]
        public string? FathersNameBn { get; set; }

        [StringLength(200)]
        public string? MothersName { get; set; }

        [StringLength(200)]
        public string? MothersNameBn { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [StringLength(200)]
        public string? DetectionSpot { get; set; }

        [StringLength(200)]
        public String? NidNo { get; set; }

        [StringLength(200)]
        public String? BirthCertifcateNo { get; set; }

        [StringLength(200)]
        public String? DrivingLicenseNo { get; set; }

        [StringLength(200)]
        public string? PassportNo { get; set; }

        [StringLength(200)]
        public string? TinNo { get; set; }

        [StringLength(200)]
        public string? CarNo { get; set; }

        [StringLength(200)]
        public string? Resident { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Height { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? Weight { get; set; }

        [StringLength(200)]
        public string? Language { get; set; }

        [StringLength(200)]
        public string? PersonalContact { get; set; }

        [StringLength(200)]
        public string? EmergencyContact { get; set; }

        /// <summary>
        /// //////////
        /// </summary>

        public bool IsActive { get; set; }

    }
}
