using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class RelativesConfig : IEntityTypeConfiguration<InformationRelative>
    {
        public void Configure(EntityTypeBuilder<InformationRelative> builder)
        {
            builder.HasData(
                 new InformationRelative
                 {
                     Id = 1,
                     FullName = "Nguyễn Văn B1",
                     BirthDay = new DateTime(1970, 09, 07),
                     PhoneNumber = "0899880028",
                     City = "Hà Nội",
                     District = "Hoàng Kiếm",
                     IdentityNumber = 12345,
                     Address = "35 Kim Mã",
                     EmployeeId = 1,
                     Relationship = "Bố"
                 },
                 new InformationRelative
                 {
                     Id = 2,
                     FullName = "Nguyễn Thị B1",
                     BirthDay = new DateTime(1970, 09, 07),
                     PhoneNumber = "0899880028",
                     City = "Hà Nội",
                     District = "Hoàng Kiếm",
                     IdentityNumber = 12345,
                     Address = "35 Kim Mã",
                     EmployeeId = 1,
                     Relationship = "Mẹ"
                 });
        }
    }
}
