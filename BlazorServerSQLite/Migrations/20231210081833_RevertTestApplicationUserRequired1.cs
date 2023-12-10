using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertTestApplicationUserRequired1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38581ec0-56c4-4858-afd2-05faa5e82e81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7013e6d3-f4f0-4364-b635-6bf5471eec71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6cdcd33-e666-46ed-9f66-bbc25c321161");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "38581ec0-56c4-4858-afd2-05faa5e82e81", "4a1b6eba-f8c7-4bb8-baa3-02bec9b61bde", "User", "USER" },
                    { "7013e6d3-f4f0-4364-b635-6bf5471eec71", "bb28c054-e6e1-4f6e-ac30-fcb4f3b6ce80", "Administrator", "ADMINISTRATOR" },
                    { "e6cdcd33-e666-46ed-9f66-bbc25c321161", "fe0a5dcc-1627-4a03-963f-9116a89f19f7", "Teacher", "TEACHER" }
                });
        }
    }
}
