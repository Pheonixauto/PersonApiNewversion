using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class vkk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c14ee6a-3c94-4cef-a519-a13c890ee6fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "642a2838-2056-4d45-b453-0e9839247804");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "InforEmployee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e1644e44-45ef-4c84-ba86-04e6e4a35302", "22257ecc-1403-48dc-98c0-0a4e1acb75b1", "Administrator", "ADMINISTRATOR" },
                    { "fe0bbd55-7cdf-4d42-b5d9-a2ed57ef42a3", "2095fb6e-235c-4def-80d1-fb38f514dde2", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "InforEmployee",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "thanhthai2604@gmail.com");

            migrationBuilder.UpdateData(
                table: "InforEmployee",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "thanhthai2604@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1644e44-45ef-4c84-ba86-04e6e4a35302");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe0bbd55-7cdf-4d42-b5d9-a2ed57ef42a3");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "InforEmployee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0c14ee6a-3c94-4cef-a519-a13c890ee6fb", "00442b2a-1f8e-4203-a305-f4a2427be636", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "642a2838-2056-4d45-b453-0e9839247804", "899a3ceb-e381-4e96-992c-127855a27e66", "Administrator", "ADMINISTRATOR" });
        }
    }
}
