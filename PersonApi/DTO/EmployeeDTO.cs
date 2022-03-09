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
        public int IdentityNumber { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty ;
        public string LastName { get; set; } = string.Empty;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string? Province { get; set; } 
        public string? City { get; set; }
        public string District { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int DepartmentId { get; set; }
    }
    public class UpdateEmployeeDTO : CreateEmployeeDTO
    {

    }
}
