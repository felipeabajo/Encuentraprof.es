using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertDataTypeEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0ca1a76a-59c9-4704-b067-c318176e05d4", "a8f036ee-8c9b-40fc-ae48-8ca6427fcf8a", "User", "USER" },
                    { "4f7867a2-93d7-470b-ab26-7cfb024cdd20", "6596322a-d877-44cd-af41-ef71db360e8e", "Administrator", "ADMINISTRATOR" },
                    { "505f7aca-f23d-4b23-8a58-73daa7ca8ba8", "1f35feda-64a6-4607-a54e-81a4dbb4b90d", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ca1a76a-59c9-4704-b067-c318176e05d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f7867a2-93d7-470b-ab26-7cfb024cdd20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "505f7aca-f23d-4b23-8a58-73daa7ca8ba8");

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
    }
}
