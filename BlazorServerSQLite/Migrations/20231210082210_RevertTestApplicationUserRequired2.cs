using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertTestApplicationUserRequired2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "074bcce7-d36c-45f2-8487-973d41b7bd68");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0878438c-8547-4ecc-9779-46219c64cd7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c05c63-a06b-4528-87be-fa8a311848f6");

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
                    { "25ef41f6-23c6-4aca-ae31-0be11c54c689", "10e075c4-ec96-49b8-a1c1-ec0baea3a82c", "Administrator", "ADMINISTRATOR" },
                    { "658b235e-3d4f-40d5-8f46-9816f1ba30f1", "89d497f9-6f99-46d1-9835-3015f1252b0f", "Teacher", "TEACHER" },
                    { "be35aca9-c802-4690-9c3d-1aea81aa0294", "141d227e-1107-493e-89fd-75111d23ff49", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ef41f6-23c6-4aca-ae31-0be11c54c689");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "658b235e-3d4f-40d5-8f46-9816f1ba30f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be35aca9-c802-4690-9c3d-1aea81aa0294");

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
                    { "074bcce7-d36c-45f2-8487-973d41b7bd68", "98b809ea-33c1-4c7c-957b-1b8936c258f3", "Teacher", "TEACHER" },
                    { "0878438c-8547-4ecc-9779-46219c64cd7d", "bd8cdb3f-10e1-4bd1-9f16-2ab7dcdeb89f", "User", "USER" },
                    { "c8c05c63-a06b-4528-87be-fa8a311848f6", "3dbcc3a5-7004-41ee-8ce1-9a67d04f6dfe", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
