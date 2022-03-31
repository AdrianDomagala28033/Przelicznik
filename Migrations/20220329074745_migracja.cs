using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektPrzelicznik.Migrations
{
    public partial class migracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rodzaj",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodzaj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jednostki",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Symbol = table.Column<string>(type: "TEXT", nullable: true),
                    RodzajeJednostekId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jednostki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jednostki_Rodzaj_RodzajeJednostekId",
                        column: x => x.RodzajeJednostekId,
                        principalTable: "Rodzaj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Przelicznik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mnoznik = table.Column<double>(type: "REAL", nullable: false),
                    JednostkiZrodloweId = table.Column<int>(type: "INTEGER", nullable: false),
                    JednostkiDocelowejId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przelicznik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Przelicznik_Jednostki_JednostkiDocelowejId",
                        column: x => x.JednostkiDocelowejId,
                        principalTable: "Jednostki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Przelicznik_Jednostki_JednostkiZrodloweId",
                        column: x => x.JednostkiZrodloweId,
                        principalTable: "Jednostki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jednostki_RodzajeJednostekId",
                table: "Jednostki",
                column: "RodzajeJednostekId");

            migrationBuilder.CreateIndex(
                name: "IX_Przelicznik_JednostkiDocelowejId",
                table: "Przelicznik",
                column: "JednostkiDocelowejId");

            migrationBuilder.CreateIndex(
                name: "IX_Przelicznik_JednostkiZrodloweId",
                table: "Przelicznik",
                column: "JednostkiZrodloweId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Przelicznik");

            migrationBuilder.DropTable(
                name: "Jednostki");

            migrationBuilder.DropTable(
                name: "Rodzaj");
        }
    }
}
