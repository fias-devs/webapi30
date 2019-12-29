using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiCore30.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zaposlenici",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JMBG = table.Column<string>(nullable: true),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenici", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Zaposlenici",
                columns: new[] { "Id", "Ime", "JMBG", "Prezime" },
                values: new object[] { 1, "Denis", "13256465489789", "Music" });

            migrationBuilder.InsertData(
                table: "Zaposlenici",
                columns: new[] { "Id", "Ime", "JMBG", "Prezime" },
                values: new object[] { 2, "Jasmin", "13256465489788", "Azemovic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zaposlenici");
        }
    }
}
