using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TeacherProfileRequestTypeOfFieldUnapprovedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "924e93b9-ecd9-4cd6-98a9-2279bdf47638");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d6a875c-cde0-4119-a61c-1649abe24312");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fed93e52-72b8-4901-b55f-d1ee6fcb5870");

            migrationBuilder.AddColumn<string>(
                name: "TypeOfField",
                table: "TeacherProfileRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UnapprovedField",
                table: "TeacherProfileRequests",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "93ce8a59-031b-4d88-be78-494e28019d28", "5bfb07af-7bd9-49a2-8bce-0df4cb25dc3e", "Teacher", "TEACHER" },
                    { "c3fd77da-1970-4354-97ab-b6f730a1cfd1", "c984e2ee-a616-42f8-9ee7-aaca10b50069", "User", "USER" },
                    { "ec46b31a-637a-49bf-81d5-3f26b47c1fa9", "730e6cac-0695-413d-b601-6a9fca0f52e8", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93ce8a59-031b-4d88-be78-494e28019d28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3fd77da-1970-4354-97ab-b6f730a1cfd1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec46b31a-637a-49bf-81d5-3f26b47c1fa9");

            migrationBuilder.DropColumn(
                name: "TypeOfField",
                table: "TeacherProfileRequests");

            migrationBuilder.DropColumn(
                name: "UnapprovedField",
                table: "TeacherProfileRequests");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "924e93b9-ecd9-4cd6-98a9-2279bdf47638", "64a524f1-f36c-41e1-b4b2-0e6ce8b6296a", "Teacher", "TEACHER" },
                    { "9d6a875c-cde0-4119-a61c-1649abe24312", "23892556-0e31-4f85-9970-05ede34fc2b1", "Administrator", "ADMINISTRATOR" },
                    { "fed93e52-72b8-4901-b55f-d1ee6fcb5870", "1252c29c-3704-4f84-8ebf-6fc229322fa9", "User", "USER" }
                });
        }
    }
}
