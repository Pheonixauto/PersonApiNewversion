using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _332215 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40b7d0c7-883f-4617-b31a-6a6c2382b5bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91e993b9-ad98-4a4c-a66e-8cb8aed76c1f");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65d2c8b2-ce7c-4e3f-be79-752036d4c1e6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6197816-e549-4616-9837-e0255231d2d8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "40b7d0c7-883f-4617-b31a-6a6c2382b5bd", "e7072d57-61c8-4720-9d3e-35b5d41c065e", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91e993b9-ad98-4a4c-a66e-8cb8aed76c1f", "c5fa5add-a149-4c53-8e1d-92476be5f6fc", "User", "USER" });
        }
    }
}
