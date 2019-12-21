using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCore30.Migrations
{
    public partial class SeedingAdded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studentis",
                columns: new[] { "Id", "Ime", "Indeks", "Prezime" },
                values: new object[] { 2, "Jasmin", "IB150052", "Azemovic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Studentis",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
