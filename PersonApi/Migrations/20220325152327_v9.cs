using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InforDepartment",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberEmployee = table.Column<int>(type: "int", nullable: false),
                    LeaderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InforDepartment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "informationPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_informationPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Learning",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Learning", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InforEmployee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<int>(type: "integer", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    District = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ScrImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InforEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InforEmployee_InforDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "InforDepartment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InforEmployee_informationPositions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "informationPositions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Employee_Learning",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StudyId = table.Column<int>(type: "int", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Learning", x => new { x.EmployeeId, x.StudyId });
                    table.ForeignKey(
                        name: "FK_Employee_Learning_InforEmployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "InforEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Learning_Learning_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Learning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Skill",
                columns: table => new
                {
                    EmployId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Skill", x => new { x.EmployId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_Employee_Skill_InforEmployee_EmployId",
                        column: x => x.EmployId,
                        principalTable: "InforEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Skill_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Relative",
                columns: table => new
                {
                    EmployeeIdRel = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentityNumberRel = table.Column<int>(type: "int", nullable: false),
                    FullNameRel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDayRel = table.Column<DateTime>(type: "date", nullable: false),
                    PhoneNumberRel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceRel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CityRel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DistrictRel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AddressRel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RelationshipRel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Relative_InforEmployee_EmployeeIdRel",
                        column: x => x.EmployeeIdRel,
                        principalTable: "InforEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTime = table.Column<DateTime>(type: "date", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(7,3)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(7,3)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salary_InforEmployee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "InforEmployee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c14ee6a-3c94-4cef-a519-a13c890ee6fb", "00442b2a-1f8e-4203-a305-f4a2427be636", "User", "USER" },
                    { "642a2838-2056-4d45-b453-0e9839247804", "899a3ceb-e381-4e96-992c-127855a27e66", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "InforDepartment",
                columns: new[] { "Id", "LeaderId", "Name", "NumberEmployee" },
                values: new object[,]
                {
                    { 1, 1, "Hành Chính Nhân Sự", 3 },
                    { 2, 2, "Hành Kế Toán Tổng Hợp", 3 },
                    { 3, 3, "Phòng Kinh Doanh", 3 }
                });

            migrationBuilder.InsertData(
                table: "Learning",
                columns: new[] { "Id", "UniversityName" },
                values: new object[,]
                {
                    { 1, "Đại Học Bách Khoa Hà Nội" },
                    { 2, "Đại Học Quốc Gia Hà Nội" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Java" },
                    { 2, "CSharp" },
                    { 3, "JavaScript" }
                });

            migrationBuilder.InsertData(
                table: "informationPositions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Trưởng phòng" });

            migrationBuilder.InsertData(
                table: "InforEmployee",
                columns: new[] { "Id", "Address", "BirthDay", "City", "DepartmentId", "District", "FirstName", "Identification", "LastName", "MiddleName", "PhoneNumber", "PositionId", "Province", "ScrImage" },
                values: new object[] { 1, "34, Kim Mã", new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", 1, "Hoàn Kiếm", "Nguyễn", 12345, "A1", "Văn", "0899880028", 1, null, "https://localhost:7263/Images/ec1-1.png" });

            migrationBuilder.InsertData(
                table: "InforEmployee",
                columns: new[] { "Id", "Address", "BirthDay", "City", "DepartmentId", "District", "FirstName", "Identification", "LastName", "MiddleName", "PhoneNumber", "PositionId", "Province", "ScrImage" },
                values: new object[] { 2, "34, Kim Mã", new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", 1, "Hoàn Kiếm", "Nguyễn", 23456, "A2", "Văn", "0899880028", null, null, null });

            migrationBuilder.InsertData(
                table: "Employee_Learning",
                columns: new[] { "EmployeeId", "StudyId", "Major", "Qualification" },
                values: new object[,]
                {
                    { 1, 1, " Công Nghệ Thông Tin", "Đại học" },
                    { 1, 2, " Cơ Khí", "Đại học" }
                });

            migrationBuilder.InsertData(
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 4.0 },
                    { 1, 2, 5.0 },
                    { 1, 3, 5.0 },
                    { 2, 2, 5.0 }
                });

            migrationBuilder.InsertData(
                table: "Relative",
                columns: new[] { "Id", "AddressRel", "BirthDayRel", "CityRel", "DistrictRel", "EmployeeIdRel", "FullNameRel", "IdentityNumberRel", "PhoneNumberRel", "ProvinceRel", "RelationshipRel" },
                values: new object[,]
                {
                    { 1, "35 Kim Mã", new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", "Hoàng Kiếm", 1, "Nguyễn Văn B1", 1234567, "0899880028", null, "Bố" },
                    { 2, "35 Kim Mã", new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", "Hoàng Kiếm", 1, "Nguyễn Thị B1", 1234589, "0899880028", null, "Mẹ" }
                });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "DateTime", "EmployeeId", "Salary", "Tax" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 500m, 10m },
                    { 2, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000m, 15m },
                    { 3, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1500m, 16m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Learning_StudyId",
                table: "Employee_Learning",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Skill_EmployId_SkillId",
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Skill_SkillId",
                table: "Employee_Skill",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_InforEmployee_DepartmentId",
                table: "InforEmployee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_InforEmployee_Identification",
                table: "InforEmployee",
                column: "Identification",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InforEmployee_PositionId",
                table: "InforEmployee",
                column: "PositionId",
                unique: true,
                filter: "[PositionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Relative_EmployeeIdRel",
                table: "Relative",
                column: "EmployeeIdRel");

            migrationBuilder.CreateIndex(
                name: "IX_Relative_IdentityNumberRel",
                table: "Relative",
                column: "IdentityNumberRel",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salary_DateTime_EmployeeId",
                table: "Salary",
                columns: new[] { "DateTime", "EmployeeId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salary_EmployeeId",
                table: "Salary",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Employee_Learning");

            migrationBuilder.DropTable(
                name: "Employee_Skill");

            migrationBuilder.DropTable(
                name: "Relative");

            migrationBuilder.DropTable(
                name: "Salary");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Learning");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "InforEmployee");

            migrationBuilder.DropTable(
                name: "InforDepartment");

            migrationBuilder.DropTable(
                name: "informationPositions");
        }
    }
}
