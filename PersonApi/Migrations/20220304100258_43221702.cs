using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _43221702 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateEmployeeSkillDTO",
                columns: table => new
                {
                    EmployId = table.Column<int>(type: "int", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.InsertData(
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId", "Rating" },
                values: new object[] { 1, 3, 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateEmployeeSkillDTO");

            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 3 });
        }
    }
}
