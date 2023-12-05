using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class Speciality : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "publicProfile",
                table: "AspNetUsers",
                newName: "PublicProfile");

            migrationBuilder.AddColumn<string>(
                name: "Speciality",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "176aed9e-55fd-4f20-871e-997140f79121", "c5e7a4d4-5eea-45b3-9182-7194469316fb", "Administrator", "ADMINISTRATOR" },
                    { "994aaf4a-3347-4ada-83fe-7f08a70f9d99", "efa2362a-6d6b-4168-bdc4-a10bd3296a40", "User", "USER" },
                    { "b3e48a62-c5c0-4bb9-8e9c-f23a6a66a0b4", "0c09309c-81d1-4125-968e-f5027431d541", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "176aed9e-55fd-4f20-871e-997140f79121");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "994aaf4a-3347-4ada-83fe-7f08a70f9d99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3e48a62-c5c0-4bb9-8e9c-f23a6a66a0b4");

            migrationBuilder.DropColumn(
                name: "Speciality",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "PublicProfile",
                table: "AspNetUsers",
                newName: "publicProfile");

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
    }
}
