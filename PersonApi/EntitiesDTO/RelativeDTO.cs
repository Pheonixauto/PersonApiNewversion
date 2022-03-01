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
        public int IdentityId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstMidName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
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
