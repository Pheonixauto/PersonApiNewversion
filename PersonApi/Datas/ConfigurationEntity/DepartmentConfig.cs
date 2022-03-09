using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class DepartmentConfig : IEntityTypeConfiguration<InformationDepartment>
    {
        public void Configure(EntityTypeBuilder<InformationDepartment> builder)
        {
            builder.ToTable("InforDepartment");
            builder.HasKey(x => x.Id);

            // config column
            builder.Property(p => p.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnName("Name")
                   .HasColumnOrder(1)
                   .HasColumnType("nvarchar");

            builder.Property(p => p.NumberEmployee);
            builder.Property(p => p.LeaderId);

            //seed
            builder.HasData(
                     new InformationDepartment
                     {
                         Id = 1,
                         Name = "Hành Chính Nhân Sự",
                         NumberEmployee = 3,
                         LeaderId = 1,
                         
                     },
                      new InformationDepartment
                      {
                          Id = 2,
                          Name = "Hành Kế Toán Tổng Hợp",
                          NumberEmployee = 3,
                          LeaderId = 2
                      },
                       new InformationDepartment
                       {
                           Id = 3,
                           Name = "Phòng Kinh Doanh",
                           NumberEmployee = 3,
                           LeaderId = 3
                       }
                );
        }
    }
}
