using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _43221627 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employee_Skill_EmployId_SkillId",
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employee_Skill_EmployId_SkillId",
                table: "Employee_Skill");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ba07d72-740d-43af-bf86-148342c2db79", "e77f1da4-76d8-434b-b0a3-e2f3c1e07b67", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46973fab-1860-4a9c-9957-6c64a2dd681e", "799ce086-bb1b-40ff-8968-e167cc2eb33e", "User", "USER" });
        }
    }
}
