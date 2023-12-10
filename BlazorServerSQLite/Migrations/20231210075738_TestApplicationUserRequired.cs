using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TestApplicationUserRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "9e881a25-1315-4ed9-9fe1-bc68fa3420d1", "5c962c45-56b6-41ff-9c0f-48eb16010238", "Teacher", "TEACHER" },
                    { "b17fa9ef-5a99-4771-a641-ec55985f2f02", "1a35e41e-87fa-4820-8df6-e33b4b457cf9", "User", "USER" },
                    { "d2ee27e8-ec99-48e2-bab7-6c8c8f3ab196", "f3664cd2-b1f3-4143-8edc-4e67de81613a", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
