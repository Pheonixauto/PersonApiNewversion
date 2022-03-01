using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8d70b24-6a4d-4a1f-8c98-8620b6710f3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efa38e12-cb66-4af0-b60d-ea7d673b0422");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6a6fc140-1c13-4dea-afe8-2214193eeae5", "13172641-8a4e-46ec-ad09-dd31312631df", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "97d86ef9-c0ec-4050-acdd-df90019a09aa", "8ff190e1-63c9-4b18-8579-f1c119927117", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b8d70b24-6a4d-4a1f-8c98-8620b6710f3f", "75d0bc2d-2ca4-42ac-9d9a-329954a38d6f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "efa38e12-cb66-4af0-b60d-ea7d673b0422", "eeef9fcb-529c-43fd-a958-8eeead63cea8", "Administrator", "ADMINISTRATOR" });
        }
    }
}
