using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TeacherContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "TeacherContact",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    TeacherId = table.Column<string>(type: "TEXT", nullable: false),
                    UnblockingDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherContact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherContact_AspNetUsers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherContact_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ac48351-792c-4843-9ad2-4ebc12bb293c", "0748436c-1751-4ae2-843e-01e46c3ec726", "Administrator", "ADMINISTRATOR" },
                    { "86651481-200e-4e56-8f97-0604b24314df", "120da034-01ab-4c98-b77b-e8bf3f985d44", "User", "USER" },
                    { "bab0e171-d7fc-48ed-a3a2-915f77578a2b", "d4837e58-cac3-48ea-ac23-5517de711870", "Teacher", "TEACHER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherContact_TeacherId",
                table: "TeacherContact",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherContact_UserId",
                table: "TeacherContact",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherContact");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ac48351-792c-4843-9ad2-4ebc12bb293c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86651481-200e-4e56-8f97-0604b24314df");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bab0e171-d7fc-48ed-a3a2-915f77578a2b");

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
    }
}
