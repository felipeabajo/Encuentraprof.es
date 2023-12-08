using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertFullEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "283bc9d8-a3fb-49a2-a601-5933d23c1eb8", "1d109ccd-5208-448b-9b3f-df543cdb758f", "User", "USER" },
                    { "3e4278e2-9f1b-486e-b8a7-4c7c2c7a18ae", "99d8f7b5-a1ca-4686-9105-670d51f6ec29", "Administrator", "ADMINISTRATOR" },
                    { "9699dbbb-4580-49b8-a34a-22b2c6baa413", "adc66adc-17ce-4dce-a184-10a2c2b77ab0", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "283bc9d8-a3fb-49a2-a601-5933d23c1eb8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e4278e2-9f1b-486e-b8a7-4c7c2c7a18ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9699dbbb-4580-49b8-a34a-22b2c6baa413");

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
    }
}
