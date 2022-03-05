using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{

    public class DepartmentDTO : CreateDepartmentDTO
    {
        public int Id { get; set; }
        public virtual ICollection<EmployeeDTO> EmployeeDTOs { get; set; } = new List<EmployeeDTO>();

    }
    public class CreateDepartmentDTO
    {

        public int LeaderId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? NumberEmployee { get; set; } 

    }
    public class UpdateDepartmentDTO : CreateDepartmentDTO
    {

    }
}
