using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TestApplicationUserRequired4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Speciality",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
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
                    { "1640468f-4f7c-4896-9703-b9a8163c78a5", "cb8c28f4-1936-4768-bb3e-5162ad9e56d1", "User", "USER" },
                    { "9fa99ce4-cfd1-47c8-9884-5323aa4970ac", "20b71a59-f342-446e-8774-88ba0b743df8", "Teacher", "TEACHER" },
                    { "cbe07b8c-d243-4543-8448-af92af5f5f95", "29b6154d-686e-4ca8-a298-9001758e08c5", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1640468f-4f7c-4896-9703-b9a8163c78a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fa99ce4-cfd1-47c8-9884-5323aa4970ac");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbe07b8c-d243-4543-8448-af92af5f5f95");

            migrationBuilder.AlterColumn<string>(
                name: "Speciality",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

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
    }
}
