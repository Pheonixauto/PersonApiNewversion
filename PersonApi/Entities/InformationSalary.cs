using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Salary")]
    public class InformationSalary
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
    
        public DateTime DateTime { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [DataType(DataType.Currency)]
        public decimal Tax  { get; set; }

        [ForeignKey(nameof(InformationEmployee))]
        public int EmployeeId { get; set; }
        public virtual InformationEmployee? InformationEmployee { get; set; }
    }
}
