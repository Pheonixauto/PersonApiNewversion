using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class v030320221424 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "929ea96b-b39d-44af-838d-16afdadfebfc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a7fa8db-53bf-4cca-9031-568014837f99");

            migrationBuilder.AlterColumn<decimal>(
                name: "Tax",
                table: "Salary",
                type: "decimal(6,3)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,3)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "929ea96b-b39d-44af-838d-16afdadfebfc", "e50d6066-cd39-4809-9db1-f5efac7f9e67", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9a7fa8db-53bf-4cca-9031-568014837f99", "c2914f60-52ec-427d-81c0-2fbfe8c787ac", "Administrator", "ADMINISTRATOR" });
        }
    }
}
