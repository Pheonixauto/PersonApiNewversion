using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aafbcf1-4a90-4863-b6af-864656927f97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abc75b58-f479-4a03-be56-cb04588b264b");

            migrationBuilder.AddColumn<decimal>(
                name: "Tax",
                table: "Salary",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6419e978-f980-4a8c-b284-22d7e8a6f589", "7764156c-74e7-48d1-8b94-baaed7345761", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f865cf3c-74ac-4211-b814-a0da64839d91", "cb6b4c06-ab56-423b-90c1-f31559cf7578", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6419e978-f980-4a8c-b284-22d7e8a6f589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f865cf3c-74ac-4211-b814-a0da64839d91");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "Salary");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3aafbcf1-4a90-4863-b6af-864656927f97", "afb7f548-9a10-4173-b70e-59f904ac6531", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abc75b58-f479-4a03-be56-cb04588b264b", "3a23d5bc-477c-4a71-95ff-1d759f7f592e", "User", "USER" });
        }
    }
}
