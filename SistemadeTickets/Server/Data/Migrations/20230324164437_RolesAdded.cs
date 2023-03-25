using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemadeTickets.Server.Data.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3078837e-cd89-4bce-b96f-1802515a8d28", "86cfb60b-b3af-494f-82ae-b0cac3d017ad", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb74ce39-e163-4ecf-bab1-8becc938a749", "dd252286-756c-4706-825f-291cc06dc073", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3078837e-cd89-4bce-b96f-1802515a8d28");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb74ce39-e163-4ecf-bab1-8becc938a749");
        }
    }
}
