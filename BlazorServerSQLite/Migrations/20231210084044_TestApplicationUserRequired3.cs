using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TestApplicationUserRequired3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "4151ee28-cb08-41de-9086-b664bd03e5b0", "24968678-a43e-45a8-b606-f02ba508e886", "Administrator", "ADMINISTRATOR" },
                    { "b64a38ee-d38a-4c97-8436-5ed81ac5d9e2", "042cfa81-ec46-4d59-bc86-0a4b16daf737", "Teacher", "TEACHER" },
                    { "f5f09526-8a74-46cd-b792-300e1422442d", "3ed1b343-fb01-42c1-97ed-3904eb409a53", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4151ee28-cb08-41de-9086-b664bd03e5b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b64a38ee-d38a-4c97-8436-5ed81ac5d9e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f5f09526-8a74-46cd-b792-300e1422442d");

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
    }
}
