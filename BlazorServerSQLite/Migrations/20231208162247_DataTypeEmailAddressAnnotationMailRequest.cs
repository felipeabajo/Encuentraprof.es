using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class DataTypeEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "201b8fea-9d6d-4823-88b9-5e75ffd5a6cf", "703f116b-7fbd-4dd5-ba0c-56a2051857fb", "User", "USER" },
                    { "ba13248d-6db0-4d62-b751-7df469b38a81", "9563e3a7-6556-4aed-a733-bba1f6c78789", "Administrator", "ADMINISTRATOR" },
                    { "cb20d7b1-65ea-43fc-aa30-4872ce8d7131", "799b0738-89f6-4fb0-bac4-ede3effdbd49", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "201b8fea-9d6d-4823-88b9-5e75ffd5a6cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba13248d-6db0-4d62-b751-7df469b38a81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb20d7b1-65ea-43fc-aa30-4872ce8d7131");

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
    }
}
