using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class Relative : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a10a383-883e-4e1a-8bba-a492a031c93c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58fd3890-ec27-493d-b7b2-ef00f9e4bc9d");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c9e031d-5511-4d6e-b84f-a98590f6a513", "922003b3-b756-4542-a24f-c1eee8e19709", "Administrator", "ADMINISTRATOR" },
                    { "818c5c06-e438-4f87-b280-46009afa3130", "0e741e21-421d-44bd-b389-369a244cfbfd", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Relative",
                columns: new[] { "Id", "Address", "BirthDay", "City", "District", "EmployeeId", "FullName", "IdentityNumber", "PhoneNumber", "Province", "Relationship" },
                values: new object[,]
                {
                    { 1, "35 Kim Mã", new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", "Hoàng Kiếm", 1, "Nguyễn Văn B1", 12345, "0899880028", null, "Bố" },
                    { 2, "35 Kim Mã", new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", "Hoàng Kiếm", 1, "Nguyễn Thị B1", 12345, "0899880028", null, "Mẹ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c9e031d-5511-4d6e-b84f-a98590f6a513");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "818c5c06-e438-4f87-b280-46009afa3130");

            migrationBuilder.DeleteData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a10a383-883e-4e1a-8bba-a492a031c93c", "67d2c526-023f-407f-b53b-6f72de28b564", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58fd3890-ec27-493d-b7b2-ef00f9e4bc9d", "949b243d-878c-4797-a8ce-ddbc1de6e54d", "User", "USER" });
        }
    }
}
