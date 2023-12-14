using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class TeacherContactUpdateDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherContact_AspNetUsers_TeacherId",
                table: "TeacherContact");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherContact_AspNetUsers_UserId",
                table: "TeacherContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherContact",
                table: "TeacherContact");

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

            migrationBuilder.RenameTable(
                name: "TeacherContact",
                newName: "TeacherContacts");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherContact_UserId",
                table: "TeacherContacts",
                newName: "IX_TeacherContacts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherContact_TeacherId",
                table: "TeacherContacts",
                newName: "IX_TeacherContacts_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherContacts",
                table: "TeacherContacts",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "18d8199b-9161-4f53-be77-264796a2e59a", "c0482a52-4901-4a4d-94ff-063264e8d045", "Administrator", "ADMINISTRATOR" },
                    { "41642323-514c-4512-9802-82f11c9e644f", "dd33c616-71dc-4c1c-bfb5-d82d9c908158", "User", "USER" },
                    { "942d7057-07a1-4b7b-bd63-f136ce496568", "a143600d-bb47-4cbe-98da-e7865f66c6a3", "Teacher", "TEACHER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherContacts_AspNetUsers_TeacherId",
                table: "TeacherContacts",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherContacts_AspNetUsers_UserId",
                table: "TeacherContacts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherContacts_AspNetUsers_TeacherId",
                table: "TeacherContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherContacts_AspNetUsers_UserId",
                table: "TeacherContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherContacts",
                table: "TeacherContacts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "18d8199b-9161-4f53-be77-264796a2e59a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41642323-514c-4512-9802-82f11c9e644f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "942d7057-07a1-4b7b-bd63-f136ce496568");

            migrationBuilder.RenameTable(
                name: "TeacherContacts",
                newName: "TeacherContact");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherContacts_UserId",
                table: "TeacherContact",
                newName: "IX_TeacherContact_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherContacts_TeacherId",
                table: "TeacherContact",
                newName: "IX_TeacherContact_TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherContact",
                table: "TeacherContact",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ac48351-792c-4843-9ad2-4ebc12bb293c", "0748436c-1751-4ae2-843e-01e46c3ec726", "Administrator", "ADMINISTRATOR" },
                    { "86651481-200e-4e56-8f97-0604b24314df", "120da034-01ab-4c98-b77b-e8bf3f985d44", "User", "USER" },
                    { "bab0e171-d7fc-48ed-a3a2-915f77578a2b", "d4837e58-cac3-48ea-ac23-5517de711870", "Teacher", "TEACHER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherContact_AspNetUsers_TeacherId",
                table: "TeacherContact",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherContact_AspNetUsers_UserId",
                table: "TeacherContact",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
