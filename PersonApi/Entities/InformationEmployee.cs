﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Models
{
    [Table("Employee")]
    public class InformationEmployee
    {
        public int Id { get; set; }

        [Required]
        public int IdentityNumber { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDay { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

     
        [StringLength(200, MinimumLength = 2)]
        public string? Province { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string City { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string District { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Address { get; set; }

        [ForeignKey(nameof(ThongTinPhongBan))]
        public int DepartmentId  { get; set; }
        public  virtual InformationDepartment ThongTinPhongBan { get; set; }

        public virtual ICollection<InformationSalary> InformationSalaries { get; set; }

        public virtual ICollection<InformationEmployee_Learning> ThongTinNhanVien_HocVans { get; set; }

        public virtual  ICollection<InformationRelative> ThongTinNguoiThans { get; set; }

        public virtual List<InformationEmployee_Skill> ThongTinNhanVien_KiNangs  { get; set; }
    }
}
