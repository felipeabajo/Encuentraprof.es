using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RequiredAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dc4db56-2474-49e5-8340-44100b13ba97");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6efc062-8c97-47b2-88f8-47dfc361be92");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca3dcb5f-30c0-418d-bb6d-0a5ec2f03ee2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20503564-108f-426b-b63c-30a6022ae72f", "cd5d1745-fa77-4256-9d0d-1925c64d81e9", "Teacher", "TEACHER" },
                    { "4c19644d-313e-4bf9-8455-bb6901d5a4dc", "1a5d7bf2-1467-4787-b5bc-f5f9adc2e6f1", "Administrator", "ADMINISTRATOR" },
                    { "c8cc470f-4458-46dd-b7c7-e4541ddcf574", "f5388ece-b52a-49b8-97bf-c1602f6e1719", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20503564-108f-426b-b63c-30a6022ae72f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c19644d-313e-4bf9-8455-bb6901d5a4dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8cc470f-4458-46dd-b7c7-e4541ddcf574");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dc4db56-2474-49e5-8340-44100b13ba97", "f7cd3eba-3828-4a78-9055-113ba24e4363", "Teacher", "TEACHER" },
                    { "c6efc062-8c97-47b2-88f8-47dfc361be92", "23269397-4fa2-46ca-a1cf-71071518406f", "User", "USER" },
                    { "ca3dcb5f-30c0-418d-bb6d-0a5ec2f03ee2", "1e696f43-2e19-4e67-b166-681f0951702c", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
