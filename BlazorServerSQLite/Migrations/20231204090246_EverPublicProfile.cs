using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class EverPublicProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d789791-889e-4c1c-8679-90144daec703");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd5fb292-d923-4aaa-93cc-acbdd36e9d91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee6c7e40-4476-4b3d-bc46-bd23eaf2276e");

            migrationBuilder.AddColumn<bool>(
                name: "EverPublicProfile",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ddb0d17-57cc-4c8a-bc0f-1493d0919866", "cf72b9e2-f59c-4088-a5fe-02eb241932b8", "Teacher", "TEACHER" },
                    { "0ea5df86-16c4-4696-938a-82b88e0eb789", "fcb99d18-8780-4da8-9f3e-f1be195f62e7", "Administrator", "ADMINISTRATOR" },
                    { "d36f867c-8c65-4100-a39d-a57fb96926ac", "95e29d5b-af14-4af0-a958-0d141d6ecd10", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ddb0d17-57cc-4c8a-bc0f-1493d0919866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ea5df86-16c4-4696-938a-82b88e0eb789");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d36f867c-8c65-4100-a39d-a57fb96926ac");

            migrationBuilder.DropColumn(
                name: "EverPublicProfile",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d789791-889e-4c1c-8679-90144daec703", "3bf58cb5-1cbe-4ce5-8877-b92ec2b0e312", "Administrator", "ADMINISTRATOR" },
                    { "bd5fb292-d923-4aaa-93cc-acbdd36e9d91", "c70875d4-949f-44f9-a70e-27413ac4d41f", "Teacher", "TEACHER" },
                    { "ee6c7e40-4476-4b3d-bc46-bd23eaf2276e", "4c13b75e-9924-4c77-810c-34b7698d6016", "User", "USER" }
                });
        }
    }
}
