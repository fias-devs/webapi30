using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCore30.Migrations
{
    public partial class SeedingAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studentis",
                columns: new[] { "Id", "Ime", "Indeks", "Prezime" },
                values: new object[] { 1, "Denis", "IB150051", "Music" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Studentis",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
