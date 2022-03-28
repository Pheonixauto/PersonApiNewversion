using PersonApi.Entities;
using PersonApi.Models;

namespace PersonApi.DTO.TestDTO
{
    public class TestDTO
    {
        private string? scrimage;
        public int Id { get; set; }
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Province { get; set; }
        public string? City { get; set; }
        public string District { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string? ScrImage { get; set; }     
        public int DepartmentId { get; set; }
        public virtual InforDepartment InformationDepartment { get; set; }
        public int? PositionId { get; set; }
        public virtual InforPosition InformationPosition { get; set; }
        public virtual List<InforSalary> InformationSalaries { get; set; }
        public virtual ICollection<InforEmployeeLearning> InformationEmployeeLearnings { get; set; }
        public virtual ICollection<InforRelative> InformationRelatives { get; set; }
        public virtual List<InforEmployeeSkill> InformationEmployeeSkills { get; set; }
    }
}
