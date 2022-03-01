using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class DepartmentConfig : IEntityTypeConfiguration<InformationDepartment>
    {
        public void Configure(EntityTypeBuilder<InformationDepartment> builder)
        {
            builder.HasData(
                     new InformationDepartment
                     {
                         Id = 1,
                         Name = "Hành Chính Nhân Sự",
                         NumberEmployee = 3,
                         LeaderId = 1
                     }
                );
        }
    }
}
