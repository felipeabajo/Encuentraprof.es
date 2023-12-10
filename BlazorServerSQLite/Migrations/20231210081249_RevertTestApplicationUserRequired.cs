using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertTestApplicationUserRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb027bb-7311-4aea-8ce3-f1c32bb80520");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "876e530e-77e9-4ab7-ad13-96450d3fd5b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa518e05-c03d-4d85-b461-f91c0be4106a");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Province",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
                    { "2bb027bb-7311-4aea-8ce3-f1c32bb80520", "24703d92-82de-4d01-b67e-05aa4fd6cbf9", "User", "USER" },
                    { "876e530e-77e9-4ab7-ad13-96450d3fd5b1", "febaabb0-4094-4f83-958f-36ded96f55fa", "Administrator", "ADMINISTRATOR" },
                    { "fa518e05-c03d-4d85-b461-f91c0be4106a", "4e25dcdc-b721-40f2-9086-8777bea46038", "Teacher", "TEACHER" }
                });
        }
    }
}
