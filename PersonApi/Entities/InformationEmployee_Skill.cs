using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee_Skill")]
    public class InformationEmployee_Skill
    {
  
        public int EmployId { get; set; }   
        public virtual InformationEmployee ThongTinNhanVien { get; set; }

        public int SkillId { get; set; }
        public virtual InformationSkill ThongTinKiNang { get; set; }

        [Range(0, 10)]
        public double Rating { get; set; }

    }
}
