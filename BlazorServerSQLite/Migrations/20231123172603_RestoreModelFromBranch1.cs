using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RestoreModelFromBranch1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a639580-6fbd-419d-8e5c-895ec54dcabd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dc61c32-62cd-41d2-84ee-2cf59dca5191");

            migrationBuilder.AlterColumn<string>(
                name: "Province",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Lastname",
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

            migrationBuilder.AddColumn<bool>(
                name: "publicProfile",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeacherProfileRequests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    TeacherProfileRequestDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TeacherProfileRequestState = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherProfileRequests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d3a79ef-bc4e-48cb-9964-389f679abd28", "a7bba5f8-cede-4d11-b9f5-2d5c326b9cad", "Administrator", "ADMINISTRATOR" },
                    { "4212d479-d6c9-47de-955c-b913c5795c84", "5e383feb-59f4-4e45-b630-b5827f66d8f9", "Teacher", "TEACHER" },
                    { "4e2dc157-1f94-4975-ab9f-4f6a0df7fb7e", "98425717-99a6-490a-9bc3-c98a8861945e", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherProfileRequests");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d3a79ef-bc4e-48cb-9964-389f679abd28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4212d479-d6c9-47de-955c-b913c5795c84");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e2dc157-1f94-4975-ab9f-4f6a0df7fb7e");

            migrationBuilder.DropColumn(
                name: "publicProfile",
                table: "AspNetUsers");

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
                name: "Lastname",
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
                    { "1a639580-6fbd-419d-8e5c-895ec54dcabd", "35be43bf-be2c-488b-aeb3-284a571e0874", "Teacher", "TEACHER" },
                    { "2dc61c32-62cd-41d2-84ee-2cf59dca5191", "82014a1c-3184-48b9-8ca5-cc62a563741d", "User", "USER" }
                });
        }
    }
}
