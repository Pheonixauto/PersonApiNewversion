using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class vajsj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03de3bee-b7bd-48f5-88c2-789469c296a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2f36a2-3fd7-46c6-9cf5-2041f782a4ba");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Salary",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "961de663-b57d-42f3-8ef4-78a80a2580f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c11dc172-2724-4c70-884e-cbe8f3255f52");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Salary",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03de3bee-b7bd-48f5-88c2-789469c296a7", "1e975146-8df7-44d5-abfe-f4394b1c1eb2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc2f36a2-3fd7-46c6-9cf5-2041f782a4ba", "3d01cccb-6614-49f7-8130-5a10f5a70a21", "User", "USER" });
        }
    }
}
