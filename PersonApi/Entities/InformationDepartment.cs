using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Department")]
    public class InformationDepartment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public int NumberEmployee { get; set; }

        public int LeaderId { get; set; }
        public virtual ICollection<InformationEmployee>  InformationEmployees { get; set; }

    }
}
