using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Skill")]
    public class InformationSkill
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }
  
        //public virtual  ICollection<InformationEmployee>  InformationEmployees { get; set; }
        public virtual ICollection<InformationEmployee_Skill> ThongTinNhanVien_KiNangs { get; set; }
    }
}
