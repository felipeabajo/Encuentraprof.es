using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class ApprovedFirstname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0760ccc4-3811-4865-989b-a60429444712");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bc6af31-1d28-4e87-83d9-fcf9e81aa76f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6feaca35-ac92-4ae1-8329-187c79b140fe");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "AspNetUsers",
                newName: "UnapprovedFirstname");

            migrationBuilder.AddColumn<string>(
                name: "ApprovedFirstname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ApprovedFirstname",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UnapprovedFirstname",
                table: "AspNetUsers",
                newName: "Firstname");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0760ccc4-3811-4865-989b-a60429444712", "fe76ddd9-9f16-487f-8ab1-212369cd2412", "User", "USER" },
                    { "1bc6af31-1d28-4e87-83d9-fcf9e81aa76f", "0752f7ab-c173-4766-98a9-cbed56101aa5", "Administrator", "ADMINISTRATOR" },
                    { "6feaca35-ac92-4ae1-8329-187c79b140fe", "87c1cfd6-6d3f-46bf-bfe8-562a2ba1edd9", "Teacher", "TEACHER" }
                });
        }
    }
}
