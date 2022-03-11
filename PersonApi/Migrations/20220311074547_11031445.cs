using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _11031445 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8104815a-f4b0-4316-a9ae-af412a84a1f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7051710-2f02-4f95-8a36-8e083329a4bf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43c5faf3-fecf-4dde-8a6c-3b30c7616f22", "ec46b818-fd47-499b-8a58-1e7e1bb6eaf7", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "64db4b1a-bd2f-4ee0-8758-43aefc3bdbd0", "c6163d54-eee1-40aa-aa35-b1052092f506", "User", "USER" });

            migrationBuilder.CreateIndex(
                name: "IX_InforEmployee_Identification",
                table: "InforEmployee",
                column: "Identification",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_InforEmployee_Identification",
                table: "InforEmployee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43c5faf3-fecf-4dde-8a6c-3b30c7616f22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64db4b1a-bd2f-4ee0-8758-43aefc3bdbd0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8104815a-f4b0-4316-a9ae-af412a84a1f5", "9cf21544-456c-4aa2-9a57-7a24007c8b03", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7051710-2f02-4f95-8a36-8e083329a4bf", "a192804f-902f-42ac-bd59-18e1ed4fb114", "Administrator", "ADMINISTRATOR" });
        }
    }
}
