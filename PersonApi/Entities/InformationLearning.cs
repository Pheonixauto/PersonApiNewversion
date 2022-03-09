using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Learning")]
    public class InformationLearning
    {
        public int Id { get; set; } 
        [StringLength(200, ErrorMessage = "University Name cannot be longer than 200 characters.")]
        public string? UniversityName { get; set; } 
        public virtual ICollection<InformationEmployeeLearning>  InformationEmployeeLearnings { get; set; } = new List<InformationEmployeeLearning>();
    }
}
