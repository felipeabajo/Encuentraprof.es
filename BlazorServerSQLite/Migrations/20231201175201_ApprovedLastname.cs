using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class ApprovedLastname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AspNetUsers",
                newName: "UnapprovedLastname");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedLastname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d789791-889e-4c1c-8679-90144daec703", "3bf58cb5-1cbe-4ce5-8877-b92ec2b0e312", "Administrator", "ADMINISTRATOR" },
                    { "bd5fb292-d923-4aaa-93cc-acbdd36e9d91", "c70875d4-949f-44f9-a70e-27413ac4d41f", "Teacher", "TEACHER" },
                    { "ee6c7e40-4476-4b3d-bc46-bd23eaf2276e", "4c13b75e-9924-4c77-810c-34b7698d6016", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d789791-889e-4c1c-8679-90144daec703");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd5fb292-d923-4aaa-93cc-acbdd36e9d91");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee6c7e40-4476-4b3d-bc46-bd23eaf2276e");

            migrationBuilder.DropColumn(
                name: "ApprovedLastname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UnapprovedLastname",
                table: "AspNetUsers",
                newName: "Lastname");

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
    }
}
