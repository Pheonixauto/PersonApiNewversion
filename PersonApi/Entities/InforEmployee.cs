using PersonApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    public class InforEmployee
    {
        public int Id { get; set; }
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Email { get; set; } 
        public string? Province { get; set; }
        public string? City { get; set; }
        public string District { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? ScrImage { get; set; }

        [ForeignKey(nameof(InformationDepartment))]
        public int DepartmentId { get; set; }
        public virtual InforDepartment InformationDepartment { get; set; }

        [ForeignKey("InformationPosition")]
        public int? PositionId { get; set; }
        public virtual InforPosition InformationPosition { get; set; }
        public virtual List<InforSalary> InformationSalaries { get; set; }

        public virtual ICollection<InforEmployeeLearning> InformationEmployeeLearnings { get; set; }

        public virtual ICollection<InforRelative> InformationRelatives { get; set; }

        public virtual List<InforEmployeeSkill> InformationEmployeeSkills { get; set; }

    }
}
