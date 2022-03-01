using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee_Skill")]
    public class InformationEmployeeSkill
    {
  
        public int EmployId { get; set; }   
        public virtual InformationEmployee  InformationEmployee { get; set; }

        public int SkillId { get; set; }
        public virtual InformationSkill  InformationSkill { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

    }
}
