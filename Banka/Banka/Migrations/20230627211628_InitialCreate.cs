using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Banka.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kontakt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pib = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaticniBroj = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filijalas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojPultova = table.Column<int>(type: "int", nullable: false),
                    BankaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filijalas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filijalas_Banka_BankaId",
                        column: x => x.BankaId,
                        principalTable: "Banka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uslugas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpisUsluge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provizija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false),
                    FilijalaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uslugas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uslugas_Filijalas_FilijalaId",
                        column: x => x.FilijalaId,
                        principalTable: "Filijalas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uslugas_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filijalas_BankaId",
                table: "Filijalas",
                column: "BankaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uslugas_FilijalaId",
                table: "Uslugas",
                column: "FilijalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Uslugas_KorisnikId",
                table: "Uslugas",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uslugas");

            migrationBuilder.DropTable(
                name: "Filijalas");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Banka");
        }
    }
}
