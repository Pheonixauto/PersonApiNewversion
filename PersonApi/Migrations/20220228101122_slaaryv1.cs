using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class slaaryv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aa65f22-59d4-45ed-8032-804a234919f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8532e8af-5b6c-40c7-9c59-02cc89b19e64");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3668ada4-e474-4c04-9131-c6b8ec4a8560", "a64f0a88-69f9-44f6-8cda-c7fd28a01299", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "529cda66-3f79-4d40-aa0a-f91e6d389e52", "50532545-d821-4eb6-850e-6a37410dad2b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "DateTime", "EmployeeId", "Salary", "Tax" },
                values: new object[] { 3, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1500m, 16m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3668ada4-e474-4c04-9131-c6b8ec4a8560");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529cda66-3f79-4d40-aa0a-f91e6d389e52");

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6aa65f22-59d4-45ed-8032-804a234919f1", "5d5c024e-4b1a-4f58-925d-9f8ed7a7aebd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8532e8af-5b6c-40c7-9c59-02cc89b19e64", "30f2a0b6-c975-43ad-b831-74ee5cce6a30", "Administrator", "ADMINISTRATOR" });
        }
    }
}
