using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class EmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80c69b80-a810-4eef-b7f2-711e4b0ad1bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7587545-5a20-4904-8a77-6d58a7a5302a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcf514f1-88cb-45de-86a0-ae3fd97a3ec9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "94f0dab3-8e35-4f49-80af-6e83a87fbc10", "e6775c2a-1131-462a-9215-0f9fcf5759d9", "User", "USER" },
                    { "e579b88c-6099-40a4-996a-f808f0375cf8", "ad4d5058-f70e-4e2d-8ab5-f89a3a3d5fa5", "Teacher", "TEACHER" },
                    { "eb285251-edb2-468a-95a7-a7d3aa669e72", "a2935772-897d-4461-a055-3f6abb51b264", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94f0dab3-8e35-4f49-80af-6e83a87fbc10");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e579b88c-6099-40a4-996a-f808f0375cf8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb285251-edb2-468a-95a7-a7d3aa669e72");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "80c69b80-a810-4eef-b7f2-711e4b0ad1bc", "3a8adb51-8c57-4a98-bed5-bd4a11d0aab4", "Teacher", "TEACHER" },
                    { "a7587545-5a20-4904-8a77-6d58a7a5302a", "e26e5bd0-d67e-46a1-9ca7-b7fd5e7a78f1", "User", "USER" },
                    { "dcf514f1-88cb-45de-86a0-ae3fd97a3ec9", "90e5c5fc-e6b6-498e-8dc5-d7cb2fb20221", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
