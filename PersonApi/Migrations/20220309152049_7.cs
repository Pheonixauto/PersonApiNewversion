using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_informationPositions_InforEmployee_EmployeeId",
                table: "informationPositions");

            migrationBuilder.DropIndex(
                name: "IX_informationPositions_EmployeeId",
                table: "informationPositions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e546a50-daa3-43b3-a41c-8d501d32337d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca05c4c6-f19c-48ee-9be5-53b4f7712f43");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "informationPositions");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "InforEmployee",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5d770c91-ece2-4224-aa9b-86f7d1f59d40", "dd9209f9-29b9-4a14-8e7c-909551eeb9b4", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cbb16729-769c-4813-b6a3-2998fe2b5c0b", "80e1f8bf-6cb3-4c52-a45f-6415e21eb241", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "InforEmployee",
                keyColumn: "Id",
                keyValue: 1,
                column: "PositionId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_InforEmployee_PositionId",
                table: "InforEmployee",
                column: "PositionId",
                unique: true,
                filter: "[PositionId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_InforEmployee_informationPositions_PositionId",
                table: "InforEmployee",
                column: "PositionId",
                principalTable: "informationPositions",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InforEmployee_informationPositions_PositionId",
                table: "InforEmployee");

            migrationBuilder.DropIndex(
                name: "IX_InforEmployee_PositionId",
                table: "InforEmployee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d770c91-ece2-4224-aa9b-86f7d1f59d40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbb16729-769c-4813-b6a3-2998fe2b5c0b");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "InforEmployee");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "informationPositions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1e546a50-daa3-43b3-a41c-8d501d32337d", "70efd550-bfbf-4f7f-8016-1664f85c53b1", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ca05c4c6-f19c-48ee-9be5-53b4f7712f43", "169998b2-cfa8-4cfe-ad3a-54110ec98de9", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "informationPositions",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_informationPositions_EmployeeId",
                table: "informationPositions",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_informationPositions_InforEmployee_EmployeeId",
                table: "informationPositions",
                column: "EmployeeId",
                principalTable: "InforEmployee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
