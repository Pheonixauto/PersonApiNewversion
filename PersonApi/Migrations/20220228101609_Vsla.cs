using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class Vsla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d96cbe03-2a3b-4a12-b890-841bfddb0078");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe92b51c-ef13-4da5-b2f7-0e1178a9327e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15b8a228-5427-4ae2-977d-dfe93e7e0734", "323023d5-825a-42c1-9025-34182f7bef72", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c38eea40-3770-4547-b680-426e4bfd0b6d", "2b133d42-1d84-41fd-939d-c145a0809175", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId", "Rating" },
                values: new object[] { 1, 2, 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b8a228-5427-4ae2-977d-dfe93e7e0734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c38eea40-3770-4547-b680-426e4bfd0b6d");

            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d96cbe03-2a3b-4a12-b890-841bfddb0078", "657559af-6d29-4639-a922-2fbee1b12334", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fe92b51c-ef13-4da5-b2f7-0e1178a9327e", "f4b95bbf-c1bd-4765-8273-024e5ddb063c", "User", "USER" });
        }
    }
}
