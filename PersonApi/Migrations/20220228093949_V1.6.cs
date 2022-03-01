using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6419e978-f980-4a8c-b284-22d7e8a6f589");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f865cf3c-74ac-4211-b814-a0da64839d91");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "418e3757-6baf-450a-8ad9-e9ae0c7a96dd", "efc85bf6-c90c-400c-b1dc-606af895eace", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b398b657-bd0f-4e6d-8188-6ed154749f88", "a2bccc96-6747-4019-ac12-2fa40be6c43f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "LeaderId", "Name", "NumberEmployee" },
                values: new object[] { 1, 1, "Hành Chính Nhân Sự", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "418e3757-6baf-450a-8ad9-e9ae0c7a96dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b398b657-bd0f-4e6d-8188-6ed154749f88");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6419e978-f980-4a8c-b284-22d7e8a6f589", "7764156c-74e7-48d1-8b94-baaed7345761", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f865cf3c-74ac-4211-b814-a0da64839d91", "cb6b4c06-ab56-423b-90c1-f31559cf7578", "User", "USER" });
        }
    }
}
