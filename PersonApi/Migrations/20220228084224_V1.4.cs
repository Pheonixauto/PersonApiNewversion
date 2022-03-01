using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20d48b46-cb8c-42e8-8928-cb27507d450b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c68f4fae-77da-4510-95bc-316d37637cd4");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "NumberPhone",
                table: "Department",
                newName: "LeaderId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3aafbcf1-4a90-4863-b6af-864656927f97", "afb7f548-9a10-4173-b70e-59f904ac6531", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "abc75b58-f479-4a03-be56-cb04588b264b", "3a23d5bc-477c-4a71-95ff-1d759f7f592e", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3aafbcf1-4a90-4863-b6af-864656927f97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abc75b58-f479-4a03-be56-cb04588b264b");

            migrationBuilder.RenameColumn(
                name: "LeaderId",
                table: "Department",
                newName: "NumberPhone");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Department",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20d48b46-cb8c-42e8-8928-cb27507d450b", "9206b6ac-9e9e-47b8-9a02-ed9b48cfaf04", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c68f4fae-77da-4510-95bc-316d37637cd4", "7e165209-d22d-4085-bf8e-dbcc7d942cdb", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Address", "Name", "NumberEmployee", "NumberPhone" },
                values: new object[] { 1, "Tầng 3", "Hành Chính Nhân Sự", 3, 19001009 });
        }
    }
}
