using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class Salary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c9e031d-5511-4d6e-b84f-a98590f6a513");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "818c5c06-e438-4f87-b280-46009afa3130");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b8d70b24-6a4d-4a1f-8c98-8620b6710f3f", "75d0bc2d-2ca4-42ac-9d9a-329954a38d6f", "User", "USER" },
                    { "efa38e12-cb66-4af0-b60d-ea7d673b0422", "eeef9fcb-529c-43fd-a958-8eeead63cea8", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Tax" },
                values: new object[] { new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10m });

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "EmployeeId", "Tax" },
                values: new object[] { new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 15m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "0c9e031d-5511-4d6e-b84f-a98590f6a513", "922003b3-b756-4542-a24f-c1eee8e19709", "Administrator", "ADMINISTRATOR" },
                    { "818c5c06-e438-4f87-b280-46009afa3130", "0e741e21-421d-44bd-b389-369a244cfbfd", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "Tax" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0m });

            migrationBuilder.UpdateData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "EmployeeId", "Tax" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0m });
        }
    }
}
