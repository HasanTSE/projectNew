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

        [Display(Name = "Nationality")]
        public int? NationId { get; set; }

        [ForeignKey("NationId")]

       [Display(Name = "Nationality")]
        public Nation? Nation { get; set; }

        //Nationality table here stop

        //Gender table here

        [Display(Name = "Gender")]
        public int? GenderId { get; set; }

        [ForeignKey("GenderId")]

        public Gender? Gender { get; set; }

        //Gender table close here

        //Present District table goes here

        [Display(Name = "Present district")]
        public int? PresentDistrictId { get; set; }

        [ForeignKey("PresentDistrictId")]
        
        [Display(Name = "Present district")]
        public PreDistrict? PresentDistrict { get; set; }

        //Present District table close here

        //Parmanent District table goes here
        [Display(Name = "Parmanent district")]
        public int? ParmanentDistrictId { get; set; }

        [ForeignKey("ParmanentDistrictId")]
        
        [Display(Name = "Parmanent district")]
        public ParDistrict? ParmanentDistrict { get; set; }
        //Parmanent District table close here

        //Blood Group table goes here

        [Display(Name = "Blood group")]
        public int? BloodGroupId { get; set; }
        [ForeignKey("BloodGroupId")]

        [Display(Name = "Blood group")]
        public Blood? BloodGroup { get; set; }


        //Blood Group table close here

        //Designation Table Goes Here

        [Display(Name = "Designation")]
        public int? DesignationId { get; set; }

        [ForeignKey("DesignationId")]

        public Desig? Designation { get; set; }

        //Designation Table Close Here

        //Company Table Goes Here
        [Display(Name = "Company")]
        public int? CompanyId { get; set; }

        [ForeignKey("CompanyId")]

        public Compa? Company { get; set; }
        //Company Table Close Here

        //Department Table Goes Here
        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]

        public Dept? Department { get; set; }
        //Department Table Close Here


        /// <summary>
        /// ///////
        /// </summary>
        /// 
        [Display(Name = "নিজের নাম বাংলায়")]
        [StringLength(200)]
        public string? NameBn { get; set; }

        [Display(Name = "Father's Name")]
        [StringLength(200)]
        public string? FathersName { get; set; }

        [Display(Name = "পিতার-নাম বাংলায়")]
        [StringLength(200)]
        public string? FathersNameBn { get; set; }


        [Display(Name = "Mother's Name")]
        [StringLength(200)]
        public string? MothersName { get; set; }

        [Display(Name = "মাতার-নাম বাংলায়")]
        [StringLength(200)]
        public string? MothersNameBn { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }


        [Display(Name = "Detection Spot")]
        [StringLength(200)]
        public string? DetectionSpot { get; set; }

        [Display(Name = "Nid number")]
        [StringLength(200)]
        public String? NidNo { get; set; }

        [Display(Name = "Birth certifcate number")]
        [StringLength(200)]
        public String? BirthCertifcateNo { get; set; }

        [Display(Name = "Driving license number")]
        [StringLength(200)]
        public String? DrivingLicenseNo { get; set; }

        [Display(Name = "Passport number")]
        [StringLength(200)]
        public string? PassportNo { get; set; }

        [Display(Name ="Tin number")]
        [StringLength(200)]
        public string? TinNo { get; set; }

        [Display(Name = "Car number")]
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

        [Display(Name = "Personal contact")]
        [StringLength(200)]
        public string? PersonalContact { get; set; }

        [Display(Name = "Emergency contact")]
        [StringLength(200)]
        public string? EmergencyContact { get; set; }

        /// <summary>
        /// //////////
        /// </summary>

        [Display(Name ="Is active")]
        public bool IsActive { get; set; }

    }
}
