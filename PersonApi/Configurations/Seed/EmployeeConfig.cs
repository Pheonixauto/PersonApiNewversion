using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeConfig : IEntityTypeConfiguration<InformationEmployee>
    {
        public void Configure(EntityTypeBuilder<InformationEmployee> builder)
        {
            builder.HasData(
                 new InformationEmployee
                 {
                     Id = 1,
                     IdentityNumber = 12345,
                     FirstName = "Nguyễn",
                     MiddleName = "Văn",
                     LastName = "A1",
                     BirthDay = new DateTime(1994, 04, 26),
                     City = "Hà Nội",
                     District = "Hoàn Kiếm",
                     Address = "34, Kim Mã",
                     PhoneNumber = "0899880028",
                     DepartmentId = 1,

                 }, new InformationEmployee
                 {
                     Id = 2,
                     IdentityNumber = 23456,
                     FirstName = "Nguyễn",
                     MiddleName = "Văn",
                     LastName = "A2",
                     BirthDay = new DateTime(1994, 04, 26),
                     City = "Hà Nội",
                     District = "Hoàn Kiếm",
                     Address = "34, Kim Mã",
                     PhoneNumber = "0899880028",
                     DepartmentId = 1,

                 }
                );
        }
    }
}
