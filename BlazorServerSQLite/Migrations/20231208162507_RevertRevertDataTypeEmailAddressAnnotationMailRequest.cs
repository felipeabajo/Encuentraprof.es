using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertRevertDataTypeEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5ab0ef7a-af59-4d68-aadf-52e825853972", "1fd8a55b-8f0f-44ff-b8b2-d0401c436a38", "Teacher", "TEACHER" },
                    { "b013b444-1f7f-4b11-98a5-a4e536343775", "0b14450f-cac1-4a5a-9a43-1eef174674b2", "User", "USER" },
                    { "f0681bab-dbc3-4160-823b-b9d5d0a45cfc", "8b5e276b-2ed0-439d-b921-fa35d3a3bc3c", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ab0ef7a-af59-4d68-aadf-52e825853972");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b013b444-1f7f-4b11-98a5-a4e536343775");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0681bab-dbc3-4160-823b-b9d5d0a45cfc");

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
    }
}
