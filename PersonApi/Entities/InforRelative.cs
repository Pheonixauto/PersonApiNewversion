using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Relative")]
    public class InforRelative
    {
        public int Id { get; set; }

        [Required]
        public int IdentityNumberRel { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FullNameRel { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime BirthDayRel { get; set; }

        [Required]
        public string PhoneNumberRel { get; set; }


        [StringLength(200, MinimumLength = 2)]
        public string? ProvinceRel { get; set; }


        [StringLength(200, MinimumLength = 2)]
        public string? CityRel { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string DistrictRel { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string AddressRel { get; set; }

        [Required]
        [StringLength(10)]
        public string RelationshipRel { get; set; }

        [ForeignKey(nameof(InformationEmployee))]
        [Column(Order = 1)]
        public int EmployeeIdRel { get; set; }
        public virtual InforEmployee InformationEmployee { get; set; }



    }
}
