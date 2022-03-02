﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonApi.Datas;

#nullable disable

namespace PersonApi.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220302072412_20220302_V1.7")]
    partial class _20220302_V17
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1b151a6d-40ce-4a48-98ee-90c36a630066",
                            ConcurrencyStamp = "c2eb687a-fd75-489f-8e27-1cb756dd3da4",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "3ead3ac8-4281-4d98-bedc-2de1bd452ddc",
                            ConcurrencyStamp = "74b3400c-d7c6-42ff-8f28-315ef95efa8c",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PersonApi.Models.ApiUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("PersonApi.Models.InformationDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LeaderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("NumberEmployee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LeaderId = 1,
                            Name = "Hành Chính Nhân Sự",
                            NumberEmployee = 3
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IdentityNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "34, Kim Mã",
                            BirthDay = new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hà Nội",
                            DepartmentId = 1,
                            District = "Hoàn Kiếm",
                            FirstName = "Nguyễn",
                            IdentityNumber = 12345,
                            LastName = "A1",
                            MiddleName = "Văn",
                            PhoneNumber = "0899880028"
                        },
                        new
                        {
                            Id = 2,
                            Address = "34, Kim Mã",
                            BirthDay = new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hà Nội",
                            DepartmentId = 1,
                            District = "Hoàn Kiếm",
                            FirstName = "Nguyễn",
                            IdentityNumber = 23456,
                            LastName = "A2",
                            MiddleName = "Văn",
                            PhoneNumber = "0899880028"
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployeeLearning", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("StudyId")
                        .HasColumnType("int");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("EmployeeId", "StudyId");

                    b.HasIndex("StudyId");

                    b.ToTable("Employee_Learning");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            StudyId = 1,
                            Major = " Công Nghệ Thông Tin",
                            Qualification = "Đại học"
                        },
                        new
                        {
                            EmployeeId = 1,
                            StudyId = 2,
                            Major = " Cơ Khí",
                            Qualification = "Đại học"
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployeeSkill", b =>
                {
                    b.Property<int>("EmployId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("EmployId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("Employee_Skill");

                    b.HasData(
                        new
                        {
                            EmployId = 2,
                            SkillId = 1,
                            Rating = 4.0
                        },
                        new
                        {
                            EmployId = 2,
                            SkillId = 2,
                            Rating = 5.0
                        },
                        new
                        {
                            EmployId = 1,
                            SkillId = 2,
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationLearning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UniversityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Learning");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UniversityName = "Đại Học Bách Khoa Hà Nội"
                        },
                        new
                        {
                            Id = 2,
                            UniversityName = "Đại Học Quốc Gia Hà Nội"
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationRelative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IdentityNumber")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Relative");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "35 Kim Mã",
                            BirthDay = new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hà Nội",
                            District = "Hoàng Kiếm",
                            EmployeeId = 1,
                            FullName = "Nguyễn Văn B1",
                            IdentityNumber = 12345,
                            PhoneNumber = "0899880028",
                            Relationship = "Bố"
                        },
                        new
                        {
                            Id = 2,
                            Address = "35 Kim Mã",
                            BirthDay = new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hà Nội",
                            District = "Hoàng Kiếm",
                            EmployeeId = 1,
                            FullName = "Nguyễn Thị B1",
                            IdentityNumber = 12345,
                            PhoneNumber = "0899880028",
                            Relationship = "Mẹ"
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("DateTime", "EmployeeId")
                        .IsUnique();

                    b.ToTable("Salary");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            Salary = 500m,
                            Tax = 10m
                        },
                        new
                        {
                            Id = 5,
                            DateTime = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            Salary = 1000m,
                            Tax = 15m
                        },
                        new
                        {
                            Id = 3,
                            DateTime = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 1,
                            Salary = 1500m,
                            Tax = 16m
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InformationSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Skill");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 2,
                            Name = "CSharp"
                        },
                        new
                        {
                            Id = 3,
                            Name = "JavaScript"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PersonApi.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PersonApi.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonApi.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PersonApi.Models.ApiUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployee", b =>
                {
                    b.HasOne("PersonApi.Models.InformationDepartment", "InformationDepartment")
                        .WithMany("InformationEmployees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationDepartment");
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployeeLearning", b =>
                {
                    b.HasOne("PersonApi.Models.InformationEmployee", "InformationEmployee")
                        .WithMany("InformationEmployeeLearnings")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonApi.Models.InformationLearning", "InformationLearning")
                        .WithMany("InformationEmployeeLearnings")
                        .HasForeignKey("StudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");

                    b.Navigation("InformationLearning");
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployeeSkill", b =>
                {
                    b.HasOne("PersonApi.Models.InformationEmployee", "InformationEmployee")
                        .WithMany("InformationEmployeeSkills")
                        .HasForeignKey("EmployId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonApi.Models.InformationSkill", "InformationSkill")
                        .WithMany("InformationEmployeeSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");

                    b.Navigation("InformationSkill");
                });

            modelBuilder.Entity("PersonApi.Models.InformationRelative", b =>
                {
                    b.HasOne("PersonApi.Models.InformationEmployee", "InformationEmployee")
                        .WithMany("InformationRelatives")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");
                });

            modelBuilder.Entity("PersonApi.Models.InformationSalary", b =>
                {
                    b.HasOne("PersonApi.Models.InformationEmployee", "InformationEmployee")
                        .WithMany("InformationSalaries")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");
                });

            modelBuilder.Entity("PersonApi.Models.InformationDepartment", b =>
                {
                    b.Navigation("InformationEmployees");
                });

            modelBuilder.Entity("PersonApi.Models.InformationEmployee", b =>
                {
                    b.Navigation("InformationEmployeeLearnings");

                    b.Navigation("InformationEmployeeSkills");

                    b.Navigation("InformationRelatives");

                    b.Navigation("InformationSalaries");
                });

            modelBuilder.Entity("PersonApi.Models.InformationLearning", b =>
                {
                    b.Navigation("InformationEmployeeLearnings");
                });

            modelBuilder.Entity("PersonApi.Models.InformationSkill", b =>
                {
                    b.Navigation("InformationEmployeeSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
