using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee")]
    public class InformationEmployee
    {

        [Column(Order = 0)]
        public int Id { get; set; }

        [Required]
        [Column(Order = 1)]
        public int IdentityNumber { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        [Column("FirstName ", Order = 2)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string MiddleName { get; set; } = string.Empty;

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime BirthDay { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;


        [StringLength(200, MinimumLength = 2)]
        public string? Province { get; set; }

        [StringLength(200, MinimumLength = 2)]
        public string? City { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string District { get; set; } = string.Empty;

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; } = string.Empty;

        [ForeignKey(nameof(InformationDepartment))]
        public int DepartmentId { get; set; }
        public virtual InformationDepartment InformationDepartment { get; set; } 

        public virtual List<InformationSalary> InformationSalaries { get; set; }/* = new List<InformationSalary>();*/

        public virtual ICollection<InformationEmployeeLearning> InformationEmployeeLearnings { get; set; } = new List<InformationEmployeeLearning>();

        public virtual ICollection<InformationRelative> InformationRelatives { get; set; } = new List<InformationRelative>();

        public virtual List<InformationEmployeeSkill> InformationEmployeeSkills { get; set; } = new List<InformationEmployeeSkill>();
    }
}
