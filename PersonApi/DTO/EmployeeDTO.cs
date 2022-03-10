using CsvHelper.Configuration.Attributes;
using PersonApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.ModelsDTO
{
    public class EmployeeDTO : CreateEmployeeDTO
    {
        public int Id { get; set; }

        public virtual DepartmentDTO DepartmentDTO { get; set; } = new DepartmentDTO();

    }

    public class CreateEmployeeDTO

    {

        [Column("IdentityNumber")]
        public int IdentityNumber { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; } = string.Empty;

        [Column("MiddleName")]
        public string MiddleName { get; set; } = string.Empty;

        [Column("LastName")]
        public string LastName { get; set; } = string.Empty;

        [Column("BirthDay")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Column("Province")]
        public string? Province { get; set; }

        [Column("City")]
        public string? City { get; set; }

        [Column("District")]
        public string District { get; set; } = string.Empty;

        [Column("Address")]
        public string Address { get; set; } = string.Empty;

        [Column("DepartmentId")]
        public int DepartmentId { get; set; }

        [Column("PositionId")]
        public int? PositionId { get; set; }

    }
    public class UpdateEmployeeDTO : CreateEmployeeDTO
    {

    }
}
