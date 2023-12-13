using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TeacherSaving : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1640468f-4f7c-4896-9703-b9a8163c78a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fa99ce4-cfd1-47c8-9884-5323aa4970ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbe07b8c-d243-4543-8448-af92af5f5f95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a0698fd-c2a5-4f1c-b94d-a2ae774b5465", "7dd1a1d0-c91d-4436-aace-0b27e1b45a49", "User", "USER" },
                    { "7214549a-e533-485d-be29-f663e07aa467", "f2421d71-6320-47d6-ab91-d110ffadff95", "Teacher", "TEACHER" },
                    { "de195f4a-b679-4d66-9377-1368d69dbc97", "3fdd61be-78dc-4738-8bba-7c050dd15cd6", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0698fd-c2a5-4f1c-b94d-a2ae774b5465");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7214549a-e533-485d-be29-f663e07aa467");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de195f4a-b679-4d66-9377-1368d69dbc97");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1640468f-4f7c-4896-9703-b9a8163c78a5", "cb8c28f4-1936-4768-bb3e-5162ad9e56d1", "User", "USER" },
                    { "9fa99ce4-cfd1-47c8-9884-5323aa4970ac", "20b71a59-f342-446e-8774-88ba0b743df8", "Teacher", "TEACHER" },
                    { "cbe07b8c-d243-4543-8448-af92af5f5f95", "29b6154d-686e-4ca8-a298-9001758e08c5", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
