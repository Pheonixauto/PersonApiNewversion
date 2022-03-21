using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class RelativesConfig : IEntityTypeConfiguration<InforRelative>
    {
        public void Configure(EntityTypeBuilder<InforRelative> builder)
        {
            builder.HasIndex(c => c.IdentityNumberRel)
                   .IsUnique();


            builder.HasData(
                 new InforRelative
                 {
                     Id = 1,
                     FullNameRel = "Nguyễn Văn B1",
                     BirthDayRel = new DateTime(1970, 09, 07),
                     PhoneNumberRel = "0899880028",
                     CityRel = "Hà Nội",
                     DistrictRel = "Hoàng Kiếm",
                     IdentityNumberRel = 1234567,
                     AddressRel = "35 Kim Mã",
                     EmployeeIdRel = 1,
                     RelationshipRel = "Bố"
                 },
                 new InforRelative
                 {
                     Id = 2,
                     FullNameRel = "Nguyễn Thị B1",
                     BirthDayRel = new DateTime(1970, 09, 07),
                     PhoneNumberRel = "0899880028",
                     CityRel = "Hà Nội",
                     DistrictRel = "Hoàng Kiếm",
                     IdentityNumberRel = 1234589,
                     AddressRel = "35 Kim Mã",
                     EmployeeIdRel = 1,
                     RelationshipRel = "Mẹ"
                 });
        }
    }
}
