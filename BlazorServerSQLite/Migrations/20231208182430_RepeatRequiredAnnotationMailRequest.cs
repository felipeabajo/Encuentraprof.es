using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RepeatRequiredAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "9e881a25-1315-4ed9-9fe1-bc68fa3420d1", "5c962c45-56b6-41ff-9c0f-48eb16010238", "Teacher", "TEACHER" },
                    { "b17fa9ef-5a99-4771-a641-ec55985f2f02", "1a35e41e-87fa-4820-8df6-e33b4b457cf9", "User", "USER" },
                    { "d2ee27e8-ec99-48e2-bab7-6c8c8f3ab196", "f3664cd2-b1f3-4143-8edc-4e67de81613a", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e881a25-1315-4ed9-9fe1-bc68fa3420d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b17fa9ef-5a99-4771-a641-ec55985f2f02");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d2ee27e8-ec99-48e2-bab7-6c8c8f3ab196");

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
    }
}
