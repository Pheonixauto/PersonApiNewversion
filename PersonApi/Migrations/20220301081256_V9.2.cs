using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V92 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57502a93-9f60-42c6-9744-cc7c8684fd9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dbba32f-2c78-490a-aa51-4ea7592ea4b5");

         
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b2421c8-b304-4628-92bd-b20f900e6021");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59ddea5-53d4-4a0b-93b6-cdaf3fa8aa35");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57502a93-9f60-42c6-9744-cc7c8684fd9c", "1678459d-97ac-4b53-9872-4763ccc6157b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8dbba32f-2c78-490a-aa51-4ea7592ea4b5", "8024e1c5-21a7-4cb8-b56f-91ca5bb75d19", "Administrator", "ADMINISTRATOR" });
        }
    }
}
