using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserExtension1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219ffb18-90b0-4305-8625-7d49b8b718d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "faae85cc-9d4b-4990-8cbf-005a1ea7f94a");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a639580-6fbd-419d-8e5c-895ec54dcabd", "35be43bf-be2c-488b-aeb3-284a571e0874", "Teacher", "TEACHER" },
                    { "2dc61c32-62cd-41d2-84ee-2cf59dca5191", "82014a1c-3184-48b9-8ca5-cc62a563741d", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a639580-6fbd-419d-8e5c-895ec54dcabd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dc61c32-62cd-41d2-84ee-2cf59dca5191");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Province",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "219ffb18-90b0-4305-8625-7d49b8b718d9", "7e5ed97d-fa2b-46ad-903d-a3bb5048b28f", "User", "USER" },
                    { "faae85cc-9d4b-4990-8cbf-005a1ea7f94a", "2db7cfd2-e706-4ff9-b015-4ea6134994d2", "Teacher", "TEACHER" }
                });
        }
    }
}
