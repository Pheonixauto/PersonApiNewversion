﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonApi.Models;

namespace PersonApi.Configurations.Entities
{
    public class EmployeeConfig : IEntityTypeConfiguration<InformationEmployee>
    {
        public void Configure(EntityTypeBuilder<InformationEmployee> builder)
        {
            // Map Entity to table
            builder.ToTable("InforEmployee");
            // Config primary key
            //builder.HasKey(e => e.Id);
            
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