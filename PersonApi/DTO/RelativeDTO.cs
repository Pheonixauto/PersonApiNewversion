using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class RelativeDTO : CreateRelativeDTO
    {
        public int Id { get; set; }
        

    }
    public class CreateRelativeDTO
    {
        [Required]
        public int IdentityNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FullName { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        public string PhoneNumber { get; set; }


        [StringLength(200, MinimumLength = 2)]
        public string? Province { get; set; }


        [StringLength(200, MinimumLength = 2)]
        public string? City { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string District { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Relationship { get; set; }
        public int EmployeeId { get; set; }
    }
    public class UpdateRelativeDTO : CreateRelativeDTO
    {

    }
}
