using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "07b7670a-bd49-461b-b50c-8af7a2604481", "52a99231-05f8-48b4-a789-eb290d1fe5c9", "Teacher", "TEACHER" },
                    { "9a66d3c4-be3e-4284-963d-fd23144c135b", "740590d8-6e31-4704-ae20-3faf46f06464", "Administrator", "ADMINISTRATOR" },
                    { "ccd57d01-f793-43d7-8393-98a32354fef1", "62ef3c0c-ebcb-424d-8d36-37a51b0b4442", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07b7670a-bd49-461b-b50c-8af7a2604481");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a66d3c4-be3e-4284-963d-fd23144c135b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccd57d01-f793-43d7-8393-98a32354fef1");

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
    }
}
