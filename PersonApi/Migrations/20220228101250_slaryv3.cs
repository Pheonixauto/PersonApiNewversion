using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class slaryv3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4716e02c-f392-4fe0-9958-c64e148b410e", "61cc043f-6827-45df-ab37-c3b8d02355da", "User", "USER" },
                    { "f64735f2-5ece-4fdb-93ec-4cb587243d8a", "c7d6688c-63e1-4051-9b7e-70de33ad2fdd", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "DateTime", "EmployeeId", "Salary", "Tax" },
                values: new object[,]
                {
                    { 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 500m, 10m },
                    { 5, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000m, 15m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4716e02c-f392-4fe0-9958-c64e148b410e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f64735f2-5ece-4fdb-93ec-4cb587243d8a");

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Salary",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3668ada4-e474-4c04-9131-c6b8ec4a8560", "a64f0a88-69f9-44f6-8cda-c7fd28a01299", "Administrator", "ADMINISTRATOR" },
                    { "529cda66-3f79-4d40-aa0a-f91e6d389e52", "50532545-d821-4eb6-850e-6a37410dad2b", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Salary",
                columns: new[] { "Id", "DateTime", "EmployeeId", "Salary", "Tax" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 500m, 10m },
                    { 2, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1000m, 15m }
                });
        }
    }
}
