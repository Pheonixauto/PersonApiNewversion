using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class EmployeeSkill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cf9d802-6b2a-4539-a665-0c47cf179df6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfcad545-dc39-47ef-8e8b-26936d18936a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a10a383-883e-4e1a-8bba-a492a031c93c", "67d2c526-023f-407f-b53b-6f72de28b564", "Administrator", "ADMINISTRATOR" },
                    { "58fd3890-ec27-493d-b7b2-ef00f9e4bc9d", "949b243d-878c-4797-a8ce-ddbc1de6e54d", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 1 },
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 2 },
                column: "Rating",
                value: 5.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a10a383-883e-4e1a-8bba-a492a031c93c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58fd3890-ec27-493d-b7b2-ef00f9e4bc9d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cf9d802-6b2a-4539-a665-0c47cf179df6", "221edc34-31ea-41c9-9c82-9f95e4d3c4cf", "Administrator", "ADMINISTRATOR" },
                    { "dfcad545-dc39-47ef-8e8b-26936d18936a", "e376b50b-f7eb-4835-805e-91b4bf242807", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 1 },
                column: "Rating",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 2 },
                column: "Rating",
                value: 0.0);
        }
    }
}
