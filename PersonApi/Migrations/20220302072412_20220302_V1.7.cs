using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _20220302_V17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8b2421c8-b304-4628-92bd-b20f900e6021");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59ddea5-53d4-4a0b-93b6-cdaf3fa8aa35");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b151a6d-40ce-4a48-98ee-90c36a630066");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ead3ac8-4281-4d98-bedc-2de1bd452ddc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8b2421c8-b304-4628-92bd-b20f900e6021", "1c935d00-5b99-4dfe-830e-c6dff1084645", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f59ddea5-53d4-4a0b-93b6-cdaf3fa8aa35", "17a28a25-2095-4b49-a681-a2732765d25b", "User", "USER" });
        }
    }
}
