using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _1103221142 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relative_InforEmployee_EmployeeId",
                table: "Relative");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d770c91-ece2-4224-aa9b-86f7d1f59d40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb16729-769c-4813-b6a3-2998fe2b5c0b");

            migrationBuilder.RenameColumn(
                name: "Relationship",
                table: "Relative",
                newName: "RelationshipRel");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "Relative",
                newName: "ProvinceRel");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Relative",
                newName: "PhoneNumberRel");

            migrationBuilder.RenameColumn(
                name: "IdentityNumber",
                table: "Relative",
                newName: "IdentityNumberRel");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Relative",
                newName: "FullNameRel");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Relative",
                newName: "EmployeeIdRel");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "Relative",
                newName: "DistrictRel");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Relative",
                newName: "CityRel");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Relative",
                newName: "BirthDayRel");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Relative",
                newName: "AddressRel");

            migrationBuilder.RenameIndex(
                name: "IX_Relative_EmployeeId",
                table: "Relative",
                newName: "IX_Relative_EmployeeIdRel");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8104815a-f4b0-4316-a9ae-af412a84a1f5", "9cf21544-456c-4aa2-9a57-7a24007c8b03", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7051710-2f02-4f95-8a36-8e083329a4bf", "a192804f-902f-42ac-bd59-18e1ed4fb114", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Relative_InforEmployee_EmployeeIdRel",
                table: "Relative",
                column: "EmployeeIdRel",
                principalTable: "InforEmployee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relative_InforEmployee_EmployeeIdRel",
                table: "Relative");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8104815a-f4b0-4316-a9ae-af412a84a1f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7051710-2f02-4f95-8a36-8e083329a4bf");

            migrationBuilder.RenameColumn(
                name: "RelationshipRel",
                table: "Relative",
                newName: "Relationship");

            migrationBuilder.RenameColumn(
                name: "ProvinceRel",
                table: "Relative",
                newName: "Province");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberRel",
                table: "Relative",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "IdentityNumberRel",
                table: "Relative",
                newName: "IdentityNumber");

            migrationBuilder.RenameColumn(
                name: "FullNameRel",
                table: "Relative",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "EmployeeIdRel",
                table: "Relative",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "DistrictRel",
                table: "Relative",
                newName: "District");

            migrationBuilder.RenameColumn(
                name: "CityRel",
                table: "Relative",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "BirthDayRel",
                table: "Relative",
                newName: "BirthDay");

            migrationBuilder.RenameColumn(
                name: "AddressRel",
                table: "Relative",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Relative_EmployeeIdRel",
                table: "Relative",
                newName: "IX_Relative_EmployeeId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d770c91-ece2-4224-aa9b-86f7d1f59d40", "dd9209f9-29b9-4a14-8e7c-909551eeb9b4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbb16729-769c-4813-b6a3-2998fe2b5c0b", "80e1f8bf-6cb3-4c52-a45f-6415e21eb241", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_Relative_InforEmployee_EmployeeId",
                table: "Relative",
                column: "EmployeeId",
                principalTable: "InforEmployee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
