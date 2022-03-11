using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonApi.Migrations
{
    public partial class _11031449 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[,]
                {
                    { "84883e55-29a3-4a53-ae92-4dcc7d127e53", "20ba6802-96fe-4ef5-a50f-6a21dd449656", "User", "USER" },
                    { "90fecefc-b6c4-4371-ad49-1ca0be98f336", "8667e5bc-a9f9-4985-8c60-df46265ec0ed", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdentityNumberRel",
                value: 1234567);

            migrationBuilder.UpdateData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdentityNumberRel",
                value: 1234589);

            migrationBuilder.CreateIndex(
                name: "IX_Relative_IdentityNumberRel",
                table: "Relative",
                column: "IdentityNumberRel",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Relative_IdentityNumberRel",
                table: "Relative");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84883e55-29a3-4a53-ae92-4dcc7d127e53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90fecefc-b6c4-4371-ad49-1ca0be98f336");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43c5faf3-fecf-4dde-8a6c-3b30c7616f22", "ec46b818-fd47-499b-8a58-1e7e1bb6eaf7", "Administrator", "ADMINISTRATOR" },
                    { "64db4b1a-bd2f-4ee0-8758-43aefc3bdbd0", "c6163d54-eee1-40aa-aa35-b1052092f506", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdentityNumberRel",
                value: 12345);

            migrationBuilder.UpdateData(
                table: "Relative",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdentityNumberRel",
                value: 12345);
        }
    }
}
