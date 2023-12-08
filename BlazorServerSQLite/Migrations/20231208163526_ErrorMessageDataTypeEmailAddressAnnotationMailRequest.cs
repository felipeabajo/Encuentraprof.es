using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class ErrorMessageDataTypeEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5ef295ab-647f-4412-bd84-5fa61f47ab63", "38936299-a189-48cb-9612-7fa98ecdd7a1", "User", "USER" },
                    { "6aeef6a0-f65e-41e0-bc97-313e0c112b30", "ad43a61d-d4a1-4672-8e56-9791acc16670", "Administrator", "ADMINISTRATOR" },
                    { "b394b7f0-cfb2-402e-b9b6-3c9a7d565b51", "be2c701e-6a5d-4484-aae6-6ba6027e1b44", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ef295ab-647f-4412-bd84-5fa61f47ab63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aeef6a0-f65e-41e0-bc97-313e0c112b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b394b7f0-cfb2-402e-b9b6-3c9a7d565b51");

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
    }
}
