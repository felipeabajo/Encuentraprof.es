using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertTestApplicationUserRequired3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "06e96d68-ae28-446c-bf19-3e4a794535f4", "9f908e11-55f8-492c-a6f4-2062448a6799", "User", "USER" },
                    { "0717d29a-e706-4e5d-9d3e-83b0b0265a5a", "78661123-e49a-4ce2-b413-c5c2a93cd116", "Teacher", "TEACHER" },
                    { "aed3b4a0-2453-43f7-962f-07beeb1aaf3f", "fbe89dc7-b4f8-445f-9dae-d7326aa403e1", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "06e96d68-ae28-446c-bf19-3e4a794535f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0717d29a-e706-4e5d-9d3e-83b0b0265a5a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aed3b4a0-2453-43f7-962f-07beeb1aaf3f");

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
    }
}
