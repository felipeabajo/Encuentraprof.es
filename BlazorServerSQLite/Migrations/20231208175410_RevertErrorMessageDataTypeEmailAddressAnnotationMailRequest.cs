using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorServerSQLite.Migrations
{
    /// <inheritdoc />
    public partial class RevertErrorMessageDataTypeEmailAddressAnnotationMailRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ef295ab-647f-4412-bd84-5fa61f47ab63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6aeef6a0-f65e-41e0-bc97-313e0c112b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b394b7f0-cfb2-402e-b9b6-3c9a7d565b51");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a40018f-404d-4d4b-96e8-1b610b92f29a", "bf745a90-336a-430f-8ce2-0d285c1fa0dc", "User", "USER" },
                    { "d091026d-6918-4b81-8b8e-5ba5b59a3468", "3c43251e-b68e-4cd5-975c-0572c2029a7a", "Teacher", "TEACHER" },
                    { "f697c2b9-22f6-4adb-af98-7c9f76da6e44", "ce122646-3891-4229-90a5-5722d0c7574a", "Administrator", "ADMINISTRATOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a40018f-404d-4d4b-96e8-1b610b92f29a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d091026d-6918-4b81-8b8e-5ba5b59a3468");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f697c2b9-22f6-4adb-af98-7c9f76da6e44");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ef295ab-647f-4412-bd84-5fa61f47ab63", "38936299-a189-48cb-9612-7fa98ecdd7a1", "User", "USER" },
                    { "6aeef6a0-f65e-41e0-bc97-313e0c112b30", "ad43a61d-d4a1-4672-8e56-9791acc16670", "Administrator", "ADMINISTRATOR" },
                    { "b394b7f0-cfb2-402e-b9b6-3c9a7d565b51", "be2c701e-6a5d-4484-aae6-6ba6027e1b44", "Teacher", "TEACHER" }
                });
        }
    }
}
