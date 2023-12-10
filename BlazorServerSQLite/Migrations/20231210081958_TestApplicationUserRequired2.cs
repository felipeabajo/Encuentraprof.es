using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TestApplicationUserRequired2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e10e83-9ef2-4a2d-96ee-3899cf6ed002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "877d1860-391d-41de-be69-f7bea69476c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a99e1865-bf9d-435b-99d5-032a0b4cc574");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "074bcce7-d36c-45f2-8487-973d41b7bd68", "98b809ea-33c1-4c7c-957b-1b8936c258f3", "Teacher", "TEACHER" },
                    { "0878438c-8547-4ecc-9779-46219c64cd7d", "bd8cdb3f-10e1-4bd1-9f16-2ab7dcdeb89f", "User", "USER" },
                    { "c8c05c63-a06b-4528-87be-fa8a311848f6", "3dbcc3a5-7004-41ee-8ce1-9a67d04f6dfe", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "074bcce7-d36c-45f2-8487-973d41b7bd68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0878438c-8547-4ecc-9779-46219c64cd7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c05c63-a06b-4528-87be-fa8a311848f6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32e10e83-9ef2-4a2d-96ee-3899cf6ed002", "8e8c47d6-fbff-4168-9422-fcc4c8533f92", "User", "USER" },
                    { "877d1860-391d-41de-be69-f7bea69476c2", "7c09b814-9720-4ad5-9b9e-2672aaa215bf", "Teacher", "TEACHER" },
                    { "a99e1865-bf9d-435b-99d5-032a0b4cc574", "81ee67a5-5519-4381-b7cf-141bb24944d4", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
