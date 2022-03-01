using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class DepartmentDTO : CreateDepartmentDTO
    {
        public int Id { get; set; }
        public virtual ICollection<EmployeeDTO> EmployeeDTOs { get; set; }

    }
    public class CreateDepartmentDTO
    {
        [Required]
        public int LeaderId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public int NumberEmployee { get; set; }

    }
    public class UpdateDepartmentDTO : CreateDepartmentDTO
    {

    }
}
