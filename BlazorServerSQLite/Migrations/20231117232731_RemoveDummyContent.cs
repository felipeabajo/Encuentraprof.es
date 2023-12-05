using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RemoveDummyContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ac2fe71-2135-4d83-af08-50ce2117dafa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64a665c4-3cd7-4a45-8bcf-387ab8f37a6c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "219ffb18-90b0-4305-8625-7d49b8b718d9", "7e5ed97d-fa2b-46ad-903d-a3bb5048b28f", "User", "USER" },
                    { "faae85cc-9d4b-4990-8cbf-005a1ea7f94a", "2db7cfd2-e706-4ff9-b015-4ea6134994d2", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219ffb18-90b0-4305-8625-7d49b8b718d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faae85cc-9d4b-4990-8cbf-005a1ea7f94a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ac2fe71-2135-4d83-af08-50ce2117dafa", "d4de5688-efa0-46d5-8b77-16b05e8e033c", "User", "USER" },
                    { "64a665c4-3cd7-4a45-8bcf-387ab8f37a6c", "d5d15541-3023-4fb1-8cb1-bdc3ba65b557", "Teacher", "TEACHER" }
                });
        }
    }
}
