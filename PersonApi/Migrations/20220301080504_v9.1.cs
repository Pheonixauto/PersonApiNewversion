using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class v91 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c815588-f169-42c6-8591-c73f70026300");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "558e2f19-79d1-494c-97c3-5911fb08d5b0");

           

            migrationBuilder.CreateIndex(
                name: "IX_Salary_DateTime_EmployeeId",
                table: "Salary",
                columns: new[] { "DateTime", "EmployeeId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Salary_DateTime_EmployeeId",
                table: "Salary");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57502a93-9f60-42c6-9744-cc7c8684fd9c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dbba32f-2c78-490a-aa51-4ea7592ea4b5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1c815588-f169-42c6-8591-c73f70026300", "1b3a18bc-994a-448d-b2ed-060dd180be3c", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "558e2f19-79d1-494c-97c3-5911fb08d5b0", "b053033c-3455-4424-ab3e-e3eeed327fff", "Administrator", "ADMINISTRATOR" });
        }
    }
}
