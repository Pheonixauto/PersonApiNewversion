using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56d96693-6e78-4af1-b964-5fb256bb8df2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7ae8a06-c7a1-4179-bf03-551837e9bc85");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c815588-f169-42c6-8591-c73f70026300", "1b3a18bc-994a-448d-b2ed-060dd180be3c", "User", "USER" },
                    { "558e2f19-79d1-494c-97c3-5911fb08d5b0", "b053033c-3455-4424-ab3e-e3eeed327fff", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Employee_Learning",
                columns: new[] { "EmployeeId", "StudyId", "Major", "Qualification" },
                values: new object[,]
                {
                    { 1, 1, " Công Nghệ Thông Tin", "Đại học" },
                    { 1, 2, " Cơ Khí", "Đại học" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c815588-f169-42c6-8591-c73f70026300");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "558e2f19-79d1-494c-97c3-5911fb08d5b0");

            migrationBuilder.DeleteData(
                table: "Employee_Learning",
                keyColumns: new[] { "EmployeeId", "StudyId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Employee_Learning",
                keyColumns: new[] { "EmployeeId", "StudyId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56d96693-6e78-4af1-b964-5fb256bb8df2", "fc55483d-f7d1-4af3-bf1a-f6df43827523", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b7ae8a06-c7a1-4179-bf03-551837e9bc85", "7bfdb5b7-215f-4c7f-b40c-3a7a8e10c323", "User", "USER" });
        }
    }
}
