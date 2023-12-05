using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class DataAnnotationsPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0760ccc4-3811-4865-989b-a60429444712", "fe76ddd9-9f16-487f-8ab1-212369cd2412", "User", "USER" },
                    { "1bc6af31-1d28-4e87-83d9-fcf9e81aa76f", "0752f7ab-c173-4766-98a9-cbed56101aa5", "Administrator", "ADMINISTRATOR" },
                    { "6feaca35-ac92-4ae1-8329-187c79b140fe", "87c1cfd6-6d3f-46bf-bfe8-562a2ba1edd9", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0760ccc4-3811-4865-989b-a60429444712");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bc6af31-1d28-4e87-83d9-fcf9e81aa76f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6feaca35-ac92-4ae1-8329-187c79b140fe");

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
    }
}
