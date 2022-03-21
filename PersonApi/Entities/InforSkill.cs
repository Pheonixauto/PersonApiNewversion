using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Skill")]
    public class InforSkill
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }
        public virtual List<InforEmployeeSkill>? InformationEmployeeSkills { get;  }
    }
}
