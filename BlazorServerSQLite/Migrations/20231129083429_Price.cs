using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class Price : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "176aed9e-55fd-4f20-871e-997140f79121");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994aaf4a-3347-4ada-83fe-7f08a70f9d99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3e48a62-c5c0-4bb9-8e9c-f23a6a66a0b4");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15d5d181-3e66-4390-8e36-4e87bb66721e", "e01bbd83-d234-4957-85d0-08ce4f601373", "Administrator", "ADMINISTRATOR" },
                    { "5684c910-d707-4cbb-8a10-81e43ae03ed1", "7a5f5bc9-9419-44cb-9648-a62f851e4f47", "Teacher", "TEACHER" },
                    { "a7bdc05b-834f-4536-b992-5d9281600cf2", "1b064944-3304-4a88-999d-66519e8d3394", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15d5d181-3e66-4390-8e36-4e87bb66721e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5684c910-d707-4cbb-8a10-81e43ae03ed1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7bdc05b-834f-4536-b992-5d9281600cf2");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "176aed9e-55fd-4f20-871e-997140f79121", "c5e7a4d4-5eea-45b3-9182-7194469316fb", "Administrator", "ADMINISTRATOR" },
                    { "994aaf4a-3347-4ada-83fe-7f08a70f9d99", "efa2362a-6d6b-4168-bdc4-a10bd3296a40", "User", "USER" },
                    { "b3e48a62-c5c0-4bb9-8e9c-f23a6a66a0b4", "0c09309c-81d1-4125-968e-f5027431d541", "Teacher", "TEACHER" }
                });
        }
    }
}
