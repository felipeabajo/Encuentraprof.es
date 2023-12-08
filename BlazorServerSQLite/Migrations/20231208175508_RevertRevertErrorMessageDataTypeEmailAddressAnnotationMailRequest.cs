using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertRevertErrorMessageDataTypeEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a40018f-404d-4d4b-96e8-1b610b92f29a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d091026d-6918-4b81-8b8e-5ba5b59a3468");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f697c2b9-22f6-4adb-af98-7c9f76da6e44");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "4a40018f-404d-4d4b-96e8-1b610b92f29a", "bf745a90-336a-430f-8ce2-0d285c1fa0dc", "User", "USER" },
                    { "d091026d-6918-4b81-8b8e-5ba5b59a3468", "3c43251e-b68e-4cd5-975c-0572c2029a7a", "Teacher", "TEACHER" },
                    { "f697c2b9-22f6-4adb-af98-7c9f76da6e44", "ce122646-3891-4229-90a5-5722d0c7574a", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
