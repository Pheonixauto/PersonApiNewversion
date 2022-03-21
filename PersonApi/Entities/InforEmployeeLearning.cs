using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee_Learning")]

    public class InforEmployeeLearning
    {
        public int EmployeeId { get; set; }
        public virtual InforEmployee InformationEmployee{ get; set; }
        public int StudyId { get; set; }
        public virtual InforLearning  InformationLearning { get; set; }

        [StringLength(20)]
        public string Major { get; set; }
        [Required]
        [StringLength(20)]
        public string Qualification { get; set; }
    }
}
