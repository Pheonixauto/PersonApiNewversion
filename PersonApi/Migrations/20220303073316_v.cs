using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class v : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0aa79780-f317-4146-96d4-d8c989378483");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daf3e1b4-da01-492a-962e-ef625750a1a2");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tax",
                table: "Salary",
                type: "decimal(7,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Salary",
                type: "decimal(7,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40b7d0c7-883f-4617-b31a-6a6c2382b5bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91e993b9-ad98-4a4c-a66e-8cb8aed76c1f");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tax",
                table: "Salary",
                type: "decimal(6,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Salary",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,3)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0aa79780-f317-4146-96d4-d8c989378483", "5cb1c828-3a8a-40a7-9d80-a749e7712277", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "daf3e1b4-da01-492a-962e-ef625750a1a2", "9e641d18-f67e-4160-a29a-c6a7e985286e", "User", "USER" });
        }
    }
}
