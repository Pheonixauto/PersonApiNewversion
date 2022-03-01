using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class DataEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418e3757-6baf-450a-8ad9-e9ae0c7a96dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b398b657-bd0f-4e6d-8188-6ed154749f88");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Employee",
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
                    { "2cf9d802-6b2a-4539-a665-0c47cf179df6", "221edc34-31ea-41c9-9c82-9f95e4d3c4cf", "Administrator", "ADMINISTRATOR" },
                    { "dfcad545-dc39-47ef-8e8b-26936d18936a", "e376b50b-f7eb-4835-805e-91b4bf242807", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "BirthDay", "City", "DepartmentId", "District", "FirstName", "IdentityNumber", "LastName", "MiddleName", "PhoneNumber", "Province" },
                values: new object[,]
                {
                    { 1, "34, Kim Mã", new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", 1, "Hoàn Kiếm", "Nguyễn", 12345, "A1", "Văn", "0899880028", null },
                    { 2, "34, Kim Mã", new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hà Nội", 1, "Hoàn Kiếm", "Nguyễn", 23456, "A2", "Văn", "0899880028", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cf9d802-6b2a-4539-a665-0c47cf179df6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfcad545-dc39-47ef-8e8b-26936d18936a");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "Employee",
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
                values: new object[] { "418e3757-6baf-450a-8ad9-e9ae0c7a96dd", "efc85bf6-c90c-400c-b1dc-606af895eace", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b398b657-bd0f-4e6d-8188-6ed154749f88", "a2bccc96-6747-4019-ac12-2fa40be6c43f", "User", "USER" });
        }
    }
}
