using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Relative")]
    public class InformationRelative
    {
        public int Id { get; set; }

        [Required]
        public int IdentityNumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "First name cannot be longer than 100 characters.")]
        public string FullName { get; set; }


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        
        [StringLength(200, MinimumLength = 2)]
        public string? Province { get; set; }

        
        [StringLength(200, MinimumLength = 2)]
        public string? City { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string District { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string Relationship { get; set; }

        [ForeignKey(nameof(InformationEmployee))]
        [Column(Order =1)]
        public int EmployeeId { get; set; }
        public virtual InformationEmployee  InformationEmployee{ get; set; }



    }
}
