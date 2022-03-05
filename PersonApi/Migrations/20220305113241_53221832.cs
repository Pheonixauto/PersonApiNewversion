using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _53221832 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 5, 1 });
        }
    }
}
