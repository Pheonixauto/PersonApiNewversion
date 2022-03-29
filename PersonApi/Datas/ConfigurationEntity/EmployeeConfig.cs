using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeConfig : IEntityTypeConfiguration<InforEmployee>
    {
        public void Configure(EntityTypeBuilder<InforEmployee> builder)
        {
            // Map Entity to table
            builder.ToTable("InforEmployee");


            builder.HasIndex(c => c.IdentityNumber)
                   .IsUnique();

            // config one to one 
            //builder.HasOne(c => c.InformationPosition).WithOne(c => c.InformationEmployee);

            //Config column
            builder.Property(p => p.Id)
                   .IsRequired()
                   .HasColumnOrder(0);

            builder.Property(p => p.IdentityNumber)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnName("Identification")
                   .HasColumnOrder(1)
                   .HasColumnType("integer");

            builder.Property(p => p.FirstName)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnName("FirstName")
                   .HasColumnOrder(2)
                   .HasColumnType("nvarchar");

            builder.Property(p => p.MiddleName)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnName("MiddleName")
                   .HasColumnOrder(3)
                   .HasColumnType("nvarchar");

            builder.Property(p => p.LastName)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnName("LastName")
                   .HasColumnOrder(4)
                   .HasColumnType("nvarchar");

            builder.Property(p => p.BirthDay)
                   .IsRequired()
                   .HasColumnName("BirthDay")
                   .HasColumnOrder(5)
                   .HasColumnType("date");

            builder.Property(p => p.PhoneNumber)
                   .IsRequired()
                   .HasMaxLength(20)
                   .HasColumnName("PhoneNumber")
                   .HasColumnOrder(6)
                   .HasColumnType("nvarchar");

            builder.Property(p => p.Province)
                   .HasMaxLength(200)
                   .HasColumnName("Province")
                   .HasColumnOrder(7)
                   .HasColumnType("nvarchar");

            builder.Property(p => p.City)
                   .HasMaxLength(200)
                   .HasColumnName("City")
                   .HasColumnType("nvarchar");

            builder.Property(p => p.District)
                   .IsRequired()
                   .HasMaxLength(200)
                   .HasColumnName("District")
                   .HasColumnType("nvarchar");

            builder.Property(p => p.Address)
                   .IsRequired()
                   .HasMaxLength(200)
                   .HasColumnName("Address")
                   .HasColumnType("nvarchar");

            //Seed
            builder.HasData(
                 new InforEmployee
                 {
                     Id = 1,
                     IdentityNumber = 12345,
                     FirstName = "Nguyễn",
                     MiddleName = "Văn",
                     LastName = "A1",
                     BirthDay = new DateTime(1994, 04, 26),
                     //Province = null,
                     City = "Hà Nội",
                     District = "Hoàn Kiếm",
                     Address = "34, Kim Mã",
                     Email="thanhthai2604@gmail.com",
                     ScrImage= "https://localhost:7263/Images/ec1-1.png",
                     PhoneNumber = "0899880028",
                     DepartmentId = 1,
                     PositionId = 1


                 }, new InforEmployee
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
                     Email="thanhthai2604@gmail.com",
                     PhoneNumber = "0899880028",
                     DepartmentId = 1,

                 }
                );
        }
    }
}
