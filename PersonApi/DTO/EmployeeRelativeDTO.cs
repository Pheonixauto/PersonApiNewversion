using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.DTO
{
    public class EmployeeRelativeDTO
    {

        [Column("IdentityNumberEmp")]
        public int IdentityNumber { get; set; }

        [Column("FirstNameEmp")]
        public string FirstName { get; set; } = string.Empty;

        [Column("MiddleNameEmp")]
        public string MiddleName { get; set; } = string.Empty;

        [Column("LastNameEmp")]
        public string LastName { get; set; } = string.Empty;

        [Column("BirthDayEmp")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Column("PhoneNumberEmp")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Column("ProvinceEmp")]
        public string? Province { get; set; }

        [Column("CityEmp")]
        public string? City { get; set; }

        [Column("DistrictEmp")]
        public string District { get; set; } = string.Empty;

        [Column("AddressEmp")]
        public string Address { get; set; } = string.Empty;

        [Column("DepartmentIdEmp")]
        public int DepartmentId { get; set; }

        [Column("PositionIdEmp")]
        public int? PositionId { get; set; }

    
        [Column("IdentityNumberRel")]
        public int IdentityNumberRel { get; set; }

        [Column("FullNameRel")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FullNameRel { get; set; }

        [Column("BirthDayRel")]

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDayRel { get; set; }


        [Column("PhoneNumberRel")]
        public string PhoneNumberRel { get; set; }


        [StringLength(200, MinimumLength = 2)]
        [Column("ProvinceRel")]
        public string? ProvinceRel { get; set; }

        [Column("CityRel")]
        [StringLength(200, MinimumLength = 2)]
        public string? CityRel { get; set; }


        [StringLength(200, MinimumLength = 2)]
        [Column("DistrictRel")]
        public string DistrictRel { get; set; }


        [StringLength(200, MinimumLength = 2)]
        [Column("AddressRel")]
        public string AddressRel { get; set; }

  
        [StringLength(10)]
        [Column("RelationshipRel")]
        public string RelationshipRel { get; set; }

        [Column("EmployeeIdRel")]
        public int EmployeeIdRel { get; set; }
    }
}
