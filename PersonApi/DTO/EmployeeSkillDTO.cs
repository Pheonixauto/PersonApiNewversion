using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.DTO
{
    public class EmployeeSkillDTO : CreateEmployeeSkillDTO
    {
    }
    public class CreateEmployeeSkillDTO
    {

        public int EmployId { get; set; }

        public int SkillId { get; set; }
        public double Rating { get; set; }

    }
}
