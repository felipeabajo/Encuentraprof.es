using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ac2fe71-2135-4d83-af08-50ce2117dafa", "d4de5688-efa0-46d5-8b77-16b05e8e033c", "User", "USER" },
                    { "64a665c4-3cd7-4a45-8bcf-387ab8f37a6c", "d5d15541-3023-4fb1-8cb1-bdc3ba65b557", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ac2fe71-2135-4d83-af08-50ce2117dafa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64a665c4-3cd7-4a45-8bcf-387ab8f37a6c");
        }
    }
}
