using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class FullEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "59271054-0af9-49d7-8e19-1bbcc62d36e8", "0040f63d-ad23-426b-9685-610ca5259fda", "User", "USER" },
                    { "7a773565-37dc-490a-98ce-998c25b5b604", "26c9c24a-ca7a-4642-adda-9db40114be33", "Administrator", "ADMINISTRATOR" },
                    { "b9de78f5-310b-4d0c-98cd-c536c8f8235c", "dbb72847-cedf-41e7-9f2d-346cfb0902eb", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59271054-0af9-49d7-8e19-1bbcc62d36e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a773565-37dc-490a-98ce-998c25b5b604");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9de78f5-310b-4d0c-98cd-c536c8f8235c");

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
    }
}
