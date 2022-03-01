using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c0611c7-1b6b-44fb-9df8-38ab76345939");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5d7dd5e-5431-4591-9f1c-12cd17ea424f");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Learning");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Learning");

            migrationBuilder.RenameColumn(
                name: "IdentityId",
                table: "Relative",
                newName: "IdentityNumber");

            migrationBuilder.RenameColumn(
                name: "IdentityId",
                table: "Employee",
                newName: "IdentityNumber");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Employee_Skill",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Employee_Learning",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Employee_Learning",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b38fd62-15ff-47ab-8c98-28bc7b5a3ba6", "babbbef9-a321-4337-b327-2257cd41fcc9", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9558cf06-1770-4fbc-bca7-0aa3892d43bd", "540f4ac9-274d-468a-b994-e1f6fc28b469", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b38fd62-15ff-47ab-8c98-28bc7b5a3ba6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9558cf06-1770-4fbc-bca7-0aa3892d43bd");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Employee_Skill");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Employee_Learning");

            migrationBuilder.DropColumn(
                name: "Major",
                table: "Employee_Learning");

            migrationBuilder.RenameColumn(
                name: "IdentityNumber",
                table: "Relative",
                newName: "IdentityId");

            migrationBuilder.RenameColumn(
                name: "IdentityNumber",
                table: "Employee",
                newName: "IdentityId");

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Skill",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Learning",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Learning",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c0611c7-1b6b-44fb-9df8-38ab76345939", "62af34f1-b236-4a09-b4d8-1fb40ad0c09c", "User", "USER" },
                    { "c5d7dd5e-5431-4591-9f1c-12cd17ea424f", "0cb124e0-14af-41f1-83b1-ca12542b87b0", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Learning",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Level", "Major" },
                values: new object[] { "Đại Học", "Công Nghệ Thông Tin" });

            migrationBuilder.UpdateData(
                table: "Learning",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Level", "Major" },
                values: new object[] { "Đại Học", "Sư Phạm" });

            migrationBuilder.UpdateData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 1,
                column: "Rating",
                value: 4.0);

            migrationBuilder.UpdateData(
                table: "Skill",
                keyColumn: "Id",
                keyValue: 2,
                column: "Rating",
                value: 4.0);
        }
    }
}
