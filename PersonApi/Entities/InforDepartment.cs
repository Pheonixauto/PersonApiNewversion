using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Department")]
    public class InforDepartment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumberEmployee { get; set; }
        public int LeaderId { get; set; }
        public virtual ICollection<InforEmployee> InformationEmployees { get; set; } = default!;
    }
}
