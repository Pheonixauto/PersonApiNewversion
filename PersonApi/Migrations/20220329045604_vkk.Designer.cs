// <auto-generated />
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
    [Migration("20220329045604_vkk")]
    partial class vkk
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
                            Id = "fe0bbd55-7cdf-4d42-b5d9-a2ed57ef42a3",
                            ConcurrencyStamp = "2095fb6e-235c-4def-80d1-fb38f514dde2",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "e1644e44-45ef-4c84-ba86-04e6e4a35302",
                            ConcurrencyStamp = "22257ecc-1403-48dc-98c0-0a4e1acb75b1",
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

            modelBuilder.Entity("PersonApi.Entities.InforPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("informationPositions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trưởng phòng"
                        });
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

            modelBuilder.Entity("PersonApi.Models.InforDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("LeaderId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name")
                        .HasColumnOrder(1);

                    b.Property<int>("NumberEmployee")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("InforDepartment", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LeaderId = 1,
                            Name = "Hành Chính Nhân Sự",
                            NumberEmployee = 3
                        },
                        new
                        {
                            Id = 2,
                            LeaderId = 2,
                            Name = "Hành Kế Toán Tổng Hợp",
                            NumberEmployee = 3
                        },
                        new
                        {
                            Id = 3,
                            LeaderId = 3,
                            Name = "Phòng Kinh Doanh",
                            NumberEmployee = 3
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InforEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Address");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date")
                        .HasColumnName("BirthDay")
                        .HasColumnOrder(5);

                    b.Property<string>("City")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("City");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("District");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("FirstName")
                        .HasColumnOrder(2);

                    b.Property<int>("IdentityNumber")
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasColumnName("Identification")
                        .HasColumnOrder(1);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("LastName")
                        .HasColumnOrder(4);

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("MiddleName")
                        .HasColumnOrder(3);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PhoneNumber")
                        .HasColumnOrder(6);

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("Province")
                        .HasColumnOrder(7);

                    b.Property<string>("ScrImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("IdentityNumber")
                        .IsUnique();

                    b.HasIndex("PositionId")
                        .IsUnique()
                        .HasFilter("[PositionId] IS NOT NULL");

                    b.ToTable("InforEmployee", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "34, Kim Mã",
                            BirthDay = new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hà Nội",
                            DepartmentId = 1,
                            District = "Hoàn Kiếm",
                            Email = "thanhthai2604@gmail.com",
                            FirstName = "Nguyễn",
                            IdentityNumber = 12345,
                            LastName = "A1",
                            MiddleName = "Văn",
                            PhoneNumber = "0899880028",
                            PositionId = 1,
                            ScrImage = "https://localhost:7263/Images/ec1-1.png"
                        },
                        new
                        {
                            Id = 2,
                            Address = "34, Kim Mã",
                            BirthDay = new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hà Nội",
                            DepartmentId = 1,
                            District = "Hoàn Kiếm",
                            Email = "thanhthai2604@gmail.com",
                            FirstName = "Nguyễn",
                            IdentityNumber = 23456,
                            LastName = "A2",
                            MiddleName = "Văn",
                            PhoneNumber = "0899880028"
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InforEmployeeLearning", b =>
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

            modelBuilder.Entity("PersonApi.Models.InforEmployeeSkill", b =>
                {
                    b.Property<int>("EmployId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("EmployId", "SkillId");

                    b.HasIndex("SkillId");

                    b.HasIndex("EmployId", "SkillId")
                        .IsUnique();

                    b.ToTable("Employee_Skill");

                    b.HasData(
                        new
                        {
                            EmployId = 1,
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
                        },
                        new
                        {
                            EmployId = 1,
                            SkillId = 3,
                            Rating = 5.0
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InforLearning", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UniversityName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

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

            modelBuilder.Entity("PersonApi.Models.InforRelative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressRel")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("BirthDayRel")
                        .HasColumnType("date");

                    b.Property<string>("CityRel")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DistrictRel")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("EmployeeIdRel")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<string>("FullNameRel")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("IdentityNumberRel")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumberRel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceRel")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("RelationshipRel")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeIdRel");

                    b.HasIndex("IdentityNumberRel")
                        .IsUnique();

                    b.ToTable("Relative");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressRel = "35 Kim Mã",
                            BirthDayRel = new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityRel = "Hà Nội",
                            DistrictRel = "Hoàng Kiếm",
                            EmployeeIdRel = 1,
                            FullNameRel = "Nguyễn Văn B1",
                            IdentityNumberRel = 1234567,
                            PhoneNumberRel = "0899880028",
                            RelationshipRel = "Bố"
                        },
                        new
                        {
                            Id = 2,
                            AddressRel = "35 Kim Mã",
                            BirthDayRel = new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CityRel = "Hà Nội",
                            DistrictRel = "Hoàng Kiếm",
                            EmployeeIdRel = 1,
                            FullNameRel = "Nguyễn Thị B1",
                            IdentityNumberRel = 1234589,
                            PhoneNumberRel = "0899880028",
                            RelationshipRel = "Mẹ"
                        });
                });

            modelBuilder.Entity("PersonApi.Models.InforSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("date");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(7,3)");

                    b.Property<decimal>("Tax")
                        .HasColumnType("decimal(7,3)");

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
                            Id = 2,
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

            modelBuilder.Entity("PersonApi.Models.InforSkill", b =>
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

            modelBuilder.Entity("PersonApi.Models.InforEmployee", b =>
                {
                    b.HasOne("PersonApi.Models.InforDepartment", "InformationDepartment")
                        .WithMany("InformationEmployees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonApi.Entities.InforPosition", "InformationPosition")
                        .WithOne("InformationEmployee")
                        .HasForeignKey("PersonApi.Models.InforEmployee", "PositionId");

                    b.Navigation("InformationDepartment");

                    b.Navigation("InformationPosition");
                });

            modelBuilder.Entity("PersonApi.Models.InforEmployeeLearning", b =>
                {
                    b.HasOne("PersonApi.Models.InforEmployee", "InformationEmployee")
                        .WithMany("InformationEmployeeLearnings")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonApi.Models.InforLearning", "InformationLearning")
                        .WithMany("InformationEmployeeLearnings")
                        .HasForeignKey("StudyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");

                    b.Navigation("InformationLearning");
                });

            modelBuilder.Entity("PersonApi.Models.InforEmployeeSkill", b =>
                {
                    b.HasOne("PersonApi.Models.InforEmployee", "InformationEmployee")
                        .WithMany("InformationEmployeeSkills")
                        .HasForeignKey("EmployId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PersonApi.Models.InforSkill", "InformationSkill")
                        .WithMany("InformationEmployeeSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");

                    b.Navigation("InformationSkill");
                });

            modelBuilder.Entity("PersonApi.Models.InforRelative", b =>
                {
                    b.HasOne("PersonApi.Models.InforEmployee", "InformationEmployee")
                        .WithMany("InformationRelatives")
                        .HasForeignKey("EmployeeIdRel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");
                });

            modelBuilder.Entity("PersonApi.Models.InforSalary", b =>
                {
                    b.HasOne("PersonApi.Models.InforEmployee", "InformationEmployee")
                        .WithMany("InformationSalaries")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InformationEmployee");
                });

            modelBuilder.Entity("PersonApi.Entities.InforPosition", b =>
                {
                    b.Navigation("InformationEmployee")
                        .IsRequired();
                });

            modelBuilder.Entity("PersonApi.Models.InforDepartment", b =>
                {
                    b.Navigation("InformationEmployees");
                });

            modelBuilder.Entity("PersonApi.Models.InforEmployee", b =>
                {
                    b.Navigation("InformationEmployeeLearnings");

                    b.Navigation("InformationEmployeeSkills");

                    b.Navigation("InformationRelatives");

                    b.Navigation("InformationSalaries");
                });

            modelBuilder.Entity("PersonApi.Models.InforLearning", b =>
                {
                    b.Navigation("InformationEmployeeLearnings");
                });

            modelBuilder.Entity("PersonApi.Models.InforSkill", b =>
                {
                    b.Navigation("InformationEmployeeSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
