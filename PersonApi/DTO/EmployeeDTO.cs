using PersonApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.ModelsDTO
{
    public class EmployeeDTO : CreateEmployeeDTO
    {
        public int Id { get; set; }
        public virtual DepartmentDTO DepartmentDTO { get; set; } = new DepartmentDTO();

    }

    public class CreateEmployeeDTO
    {

        [Required]
        public int IdentityNumber { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string MiddleName { get; set; } = string.Empty ;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        [StringLength(200, MinimumLength = 2)]
        public string? Province { get; set; } 

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string? City { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string District { get; set; } = string.Empty;

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; } = string.Empty;

        public int DepartmentId { get; set; }


    }
    public class UpdateEmployeeDTO : CreateEmployeeDTO
    {

    }
}
