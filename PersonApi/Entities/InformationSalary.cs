using AutoMapper.Configuration.Annotations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PersonApi.Models
{
    [Table("Salary")]
    public class InformationSalary
    {
        public int Id { get; set; }


        [DataType(DataType.DateTime)]
        [Column(TypeName = "date")]    
        public DateTime DateTime { get; set; } 

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(7,3)")]
        public decimal Salary { get; set; }

        //[DataType(DataType.Currency)]
        [Column(TypeName = "decimal(7,3)")]
        public decimal Tax { get; set; }

        [ForeignKey(nameof(InformationEmployee))]
        public int EmployeeId { get; set; }
        public virtual InformationEmployee? InformationEmployee { get; set; }
    }

}
