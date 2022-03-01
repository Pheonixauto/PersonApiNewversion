using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class skill12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4716e02c-f392-4fe0-9958-c64e148b410e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64735f2-5ece-4fdb-93ec-4cb587243d8a");

            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d96cbe03-2a3b-4a12-b890-841bfddb0078", "657559af-6d29-4639-a922-2fbee1b12334", "Administrator", "ADMINISTRATOR" },
                    { "fe92b51c-ef13-4da5-b2f7-0e1178a9327e", "f4b95bbf-c1bd-4765-8273-024e5ddb063c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId", "Rating" },
                values: new object[,]
                {
                    { 2, 1, 4.0 },
                    { 2, 2, 5.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d96cbe03-2a3b-4a12-b890-841bfddb0078");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe92b51c-ef13-4da5-b2f7-0e1178a9327e");

            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Employee_Skill",
                keyColumns: new[] { "EmployId", "SkillId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4716e02c-f392-4fe0-9958-c64e148b410e", "61cc043f-6827-45df-ab37-c3b8d02355da", "User", "USER" },
                    { "f64735f2-5ece-4fdb-93ec-4cb587243d8a", "c7d6688c-63e1-4051-9b7e-70de33ad2fdd", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Employee_Skill",
                columns: new[] { "EmployId", "SkillId", "Rating" },
                values: new object[,]
                {
                    { 1, 1, 4.0 },
                    { 1, 2, 5.0 }
                });
        }
    }
}
