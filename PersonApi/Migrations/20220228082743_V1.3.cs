using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a7585f4-5f08-4dad-bfb3-eeb0135c0338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91819e52-47a8-42f4-a16a-5dc61837121c");

            migrationBuilder.RenameColumn(
                name: "MidName",
                table: "Employee",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "First",
                table: "Employee",
                newName: "FirstName");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Employee",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Employee",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Employee",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20d48b46-cb8c-42e8-8928-cb27507d450b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c68f4fae-77da-4510-95bc-316d37637cd4");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Employee",
                newName: "MidName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Employee",
                newName: "First");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a7585f4-5f08-4dad-bfb3-eeb0135c0338", "69150904-2539-4ac5-8474-a11394620157", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91819e52-47a8-42f4-a16a-5dc61837121c", "37cf2962-28a6-4bc2-8a11-696890fdfc06", "Administrator", "ADMINISTRATOR" });
        }
    }
}
