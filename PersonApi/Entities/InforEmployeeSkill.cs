using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee_Skill")]
    public class InforEmployeeSkill
    {
  
        public int EmployId { get; set; }   
        public virtual InforEmployee  InformationEmployee { get; set; }

        public int SkillId { get; set; }
        public virtual InforSkill  InformationSkill { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

    }
}
