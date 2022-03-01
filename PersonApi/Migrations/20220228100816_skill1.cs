using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class skill1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a6fc140-1c13-4dea-afe8-2214193eeae5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97d86ef9-c0ec-4050-acdd-df90019a09aa");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6aa65f22-59d4-45ed-8032-804a234919f1", "5d5c024e-4b1a-4f58-925d-9f8ed7a7aebd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8532e8af-5b6c-40c7-9c59-02cc89b19e64", "30f2a0b6-c975-43ad-b831-74ee5cce6a30", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "JavaScript" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa65f22-59d4-45ed-8032-804a234919f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8532e8af-5b6c-40c7-9c59-02cc89b19e64");

            migrationBuilder.DeleteData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a6fc140-1c13-4dea-afe8-2214193eeae5", "13172641-8a4e-46ec-ad09-dd31312631df", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97d86ef9-c0ec-4050-acdd-df90019a09aa", "8ff190e1-63c9-4b18-8579-f1c119927117", "User", "USER" });
        }
    }
}
