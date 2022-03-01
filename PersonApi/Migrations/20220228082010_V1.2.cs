using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class V12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b38fd62-15ff-47ab-8c98-28bc7b5a3ba6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9558cf06-1770-4fbc-bca7-0aa3892d43bd");

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FirstMidName",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Relative");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Employee_Learning",
                newName: "Qualification");

            migrationBuilder.RenameColumn(
                name: "FirstMidName",
                table: "Employee",
                newName: "MidName");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Relative",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Relative",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Relative",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employee",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "First",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a7585f4-5f08-4dad-bfb3-eeb0135c0338", "69150904-2539-4ac5-8474-a11394620157", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "91819e52-47a8-42f4-a16a-5dc61837121c", "37cf2962-28a6-4bc2-8a11-696890fdfc06", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a7585f4-5f08-4dad-bfb3-eeb0135c0338");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91819e52-47a8-42f4-a16a-5dc61837121c");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Relative");

            migrationBuilder.DropColumn(
                name: "First",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "Qualification",
                table: "Employee_Learning",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "MidName",
                table: "Employee",
                newName: "FirstMidName");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Relative",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Relative",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "FirstMidName",
                table: "Relative",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Relative",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b38fd62-15ff-47ab-8c98-28bc7b5a3ba6", "babbbef9-a321-4337-b327-2257cd41fcc9", "User", "USER" },
                    { "9558cf06-1770-4fbc-bca7-0aa3892d43bd", "540f4ac9-274d-468a-b994-e1f6fc28b469", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "BirthDay", "DepartmentId", "FirstMidName", "IdentityNumber", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Ha Noi", new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyen Van", 12345, "A1", 899880028 },
                    { 2, "Ha Noi", new DateTime(1994, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vũ Thị", 23456, "B1", 899880028 }
                });

            migrationBuilder.InsertData(
                table: "Relative",
                columns: new[] { "Id", "Address", "BirthDay", "EmployeeId", "FirstMidName", "IdentityNumber", "LastName", "PhoneNumber", "Relationship" },
                values: new object[] { 1, "Hà Nội", new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Văn", 0, "A1", 12345, "Bố" });

            migrationBuilder.InsertData(
                table: "Relative",
                columns: new[] { "Id", "Address", "BirthDay", "EmployeeId", "FirstMidName", "IdentityNumber", "LastName", "PhoneNumber", "Relationship" },
                values: new object[] { 2, "Hà Nội", new DateTime(1970, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Nguyễn Thị", 0, "A2", 12345, "Mẹ" });
        }
    }
}
