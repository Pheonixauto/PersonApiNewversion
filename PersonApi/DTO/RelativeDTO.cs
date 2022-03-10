using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.ModelsDTO
{
    public class RelativeDTO : CreateRelativeDTO
    {
        public int Id { get; set; }


    }
    public class CreateRelativeDTO
    {
        [Required]
        [Column("IdentityNumberRelative")]
        public int IdentityNumber { get; set; }

        [Required]
        [Column("FullName")]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FullName { get; set; }

        [Column("BirthDayRelative")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        [Column("PhoneNumberRelative")]
        public string PhoneNumber { get; set; }


        [StringLength(200, MinimumLength = 2)]
        [Column("ProvinceRelative")]
        public string? Province { get; set; }

        [Column("CityRelative")]
        [StringLength(200, MinimumLength = 2)]
        public string? City { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Column("DistrictRelative")]
        public string District { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        [Column("AddressRelative")]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        [Column("Relationship")]
        public string Relationship { get; set; }

        [Column("EmployeeId")]
        public int EmployeeId { get; set; }
    }
    public class UpdateRelativeDTO : CreateRelativeDTO
    {

    }
}
