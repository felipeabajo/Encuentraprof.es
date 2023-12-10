using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TestApplicationUserRequired1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d33a64c-a057-4b20-9ee8-22f0f9c13a76");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be674f0b-e34b-4ca4-936f-7c06da40e0f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f51f53f5-0a8e-420a-b3ec-7cc1a4dddf6e");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38581ec0-56c4-4858-afd2-05faa5e82e81", "4a1b6eba-f8c7-4bb8-baa3-02bec9b61bde", "User", "USER" },
                    { "7013e6d3-f4f0-4364-b635-6bf5471eec71", "bb28c054-e6e1-4f6e-ac30-fcb4f3b6ce80", "Administrator", "ADMINISTRATOR" },
                    { "e6cdcd33-e666-46ed-9f66-bbc25c321161", "fe0a5dcc-1627-4a03-963f-9116a89f19f7", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38581ec0-56c4-4858-afd2-05faa5e82e81");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7013e6d3-f4f0-4364-b635-6bf5471eec71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e6cdcd33-e666-46ed-9f66-bbc25c321161");

            migrationBuilder.AlterColumn<string>(
                name: "Firstname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d33a64c-a057-4b20-9ee8-22f0f9c13a76", "0cc8af24-ddc0-49b5-943b-3aad8d1eb78f", "Teacher", "TEACHER" },
                    { "be674f0b-e34b-4ca4-936f-7c06da40e0f1", "7bf918ba-8e62-4b20-95b0-2a20ee0792b7", "User", "USER" },
                    { "f51f53f5-0a8e-420a-b3ec-7cc1a4dddf6e", "e8c2b51a-e181-47ff-a95f-0b2c6f136b53", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
