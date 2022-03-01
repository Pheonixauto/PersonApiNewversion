using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15b8a228-5427-4ae2-977d-dfe93e7e0734");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c38eea40-3770-4547-b680-426e4bfd0b6d");

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56d96693-6e78-4af1-b964-5fb256bb8df2", "fc55483d-f7d1-4af3-bf1a-f6df43827523", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7ae8a06-c7a1-4179-bf03-551837e9bc85", "7bfdb5b7-215f-4c7f-b40c-3a7a8e10c323", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "DateTime", "EmployeeId", "Salary", "Tax" },
                values: new object[] { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 500m, 10m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56d96693-6e78-4af1-b964-5fb256bb8df2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7ae8a06-c7a1-4179-bf03-551837e9bc85");

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "15b8a228-5427-4ae2-977d-dfe93e7e0734", "323023d5-825a-42c1-9025-34182f7bef72", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c38eea40-3770-4547-b680-426e4bfd0b6d", "2b133d42-1d84-41fd-939d-c145a0809175", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "DateTime", "EmployeeId", "Salary", "Tax" },
                values: new object[] { 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 500m, 10m });
        }
    }
}
