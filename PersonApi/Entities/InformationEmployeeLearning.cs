using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee_Learning")]

    public class InformationEmployeeLearning
    {
        public int EmployeeId { get; set; }
        public virtual InformationEmployee InformationEmployee{ get; set; }
        public int StudyId { get; set; }
        public virtual InformationLearning  InformationLearning { get; set; }

        [StringLength(20)]
        public string Major { get; set; }
        [Required]
        [StringLength(20)]
        public string Qualification { get; set; }
    }
}
