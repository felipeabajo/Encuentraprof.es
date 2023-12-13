using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TeacherSavingDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0698fd-c2a5-4f1c-b94d-a2ae774b5465");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7214549a-e533-485d-be29-f663e07aa467");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "de195f4a-b679-4d66-9377-1368d69dbc97");

            migrationBuilder.CreateTable(
                name: "TeacherSavings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    TeacherId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSavings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ff719c5-1943-488e-b0cd-5eac45c083ff", "095249c3-aa7f-4092-8bc5-1651cee435d8", "Administrator", "ADMINISTRATOR" },
                    { "a1496904-4b5a-4b32-94e4-082bd27339f8", "e8ed74d0-7ac0-44e9-be9f-934bffd14b25", "User", "USER" },
                    { "ca4d536f-d81c-4ede-97ff-2293bf55a34b", "aa72d02e-bd2e-4350-a901-7abf479b2a51", "Teacher", "TEACHER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherSavings");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ff719c5-1943-488e-b0cd-5eac45c083ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1496904-4b5a-4b32-94e4-082bd27339f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ca4d536f-d81c-4ede-97ff-2293bf55a34b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a0698fd-c2a5-4f1c-b94d-a2ae774b5465", "7dd1a1d0-c91d-4436-aace-0b27e1b45a49", "User", "USER" },
                    { "7214549a-e533-485d-be29-f663e07aa467", "f2421d71-6320-47d6-ab91-d110ffadff95", "Teacher", "TEACHER" },
                    { "de195f4a-b679-4d66-9377-1368d69dbc97", "3fdd61be-78dc-4738-8bba-7c050dd15cd6", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
