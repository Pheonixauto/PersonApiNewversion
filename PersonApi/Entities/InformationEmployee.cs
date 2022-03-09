using PersonApi.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    public class InformationEmployee
    {
        public int Id { get; set; }
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Province { get; set; }
        public string? City { get; set; }
        public string District { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        [ForeignKey(nameof(InformationDepartment))]
        public int DepartmentId { get; set; }
        public virtual InformationDepartment? InformationDepartment { get; set; }

        [ForeignKey("InformationPosition")]
        public int? PositionId { get; set; }
        public virtual InformationPosition InformationPosition { get; set; }

        public virtual List<InformationSalary> InformationSalaries { get; set; }
                       = new List<InformationSalary>();
        public virtual ICollection<InformationEmployeeLearning> InformationEmployeeLearnings { get; set; }
                       = new List<InformationEmployeeLearning>();
        public virtual ICollection<InformationRelative> InformationRelatives { get; set; }
                       = new List<InformationRelative>();
        public virtual List<InformationEmployeeSkill> InformationEmployeeSkills { get; set; }
                       = new List<InformationEmployeeSkill>();
    }
}
