using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace fpis_projekat.Migrations
{
    public partial class Pocetna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzave",
                columns: table => new
                {
                    DrzavaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivDrzave = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzave", x => x.DrzavaId);
                });

            migrationBuilder.CreateTable(
                name: "PrevoznaSredstva",
                columns: table => new
                {
                    PrevoznoSredstvoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivSredstva = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrevoznaSredstva", x => x.PrevoznoSredstvoId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivModela = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.ProizvodId);
                });

            migrationBuilder.CreateTable(
                name: "Radnici",
                columns: table => new
                {
                    RadnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radnici", x => x.RadnikId);
                });

            migrationBuilder.CreateTable(
                name: "Reklamacije",
                columns: table => new
                {
                    ReklamacijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reklamacije", x => x.ReklamacijaId);
                });

            migrationBuilder.CreateTable(
                name: "Gradovi",
                columns: table => new
                {
                    GradId = table.Column<int>(type: "int", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false),
                    NazivGrada = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradovi", x => new { x.GradId, x.DrzavaId });
                    table.ForeignKey(
                        name: "FK_Gradovi_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Karatkeristike",
                columns: table => new
                {
                    KarakteristikaId = table.Column<int>(type: "int", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    Vrednost = table.Column<double>(type: "float", nullable: false),
                    NazivKarakteristike = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karatkeristike", x => new { x.KarakteristikaId, x.ProizvodId });
                    table.ForeignKey(
                        name: "FK_Karatkeristike_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cenovnici",
                columns: table => new
                {
                    CenovnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DrzavaId = table.Column<int>(type: "int", nullable: false),
                    RadnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cenovnici", x => x.CenovnikId);
                    table.ForeignKey(
                        name: "FK_Cenovnici_Drzave_DrzavaId",
                        column: x => x.DrzavaId,
                        principalTable: "Drzave",
                        principalColumn: "DrzavaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cenovnici_Radnici_RadnikId",
                        column: x => x.RadnikId,
                        principalTable: "Radnici",
                        principalColumn: "RadnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Otpremnice",
                columns: table => new
                {
                    OtpremnicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RadnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otpremnice", x => x.OtpremnicaId);
                    table.ForeignKey(
                        name: "FK_Otpremnice_Radnici_RadnikId",
                        column: x => x.RadnikId,
                        principalTable: "Radnici",
                        principalColumn: "RadnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeReklamacije",
                columns: table => new
                {
                    StavkaReklamacijeId = table.Column<int>(type: "int", nullable: false),
                    ReklamacijaId = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeReklamacije", x => new { x.StavkaReklamacijeId, x.ReklamacijaId });
                    table.ForeignKey(
                        name: "FK_StavkeReklamacije_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeReklamacije_Reklamacije_ReklamacijaId",
                        column: x => x.ReklamacijaId,
                        principalTable: "Reklamacije",
                        principalColumn: "ReklamacijaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kupci",
                columns: table => new
                {
                    KupacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKupca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UlicaBroj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrzavaId = table.Column<int>(type: "int", nullable: false),
                    GradId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupci", x => x.KupacId);
                    table.ForeignKey(
                        name: "FK_Kupci_Gradovi_GradId_DrzavaId",
                        columns: x => new { x.GradId, x.DrzavaId },
                        principalTable: "Gradovi",
                        principalColumns: new[] { "GradId", "DrzavaId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeCenovnika",
                columns: table => new
                {
                    StavkaCenovnikaId = table.Column<int>(type: "int", nullable: false),
                    CenovnikId = table.Column<int>(type: "int", nullable: false),
                    CenaSaPDV = table.Column<double>(type: "float", nullable: false),
                    CenaBezPDV = table.Column<double>(type: "float", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeCenovnika", x => new { x.StavkaCenovnikaId, x.CenovnikId });
                    table.ForeignKey(
                        name: "FK_StavkeCenovnika_Cenovnici_CenovnikId",
                        column: x => x.CenovnikId,
                        principalTable: "Cenovnici",
                        principalColumn: "CenovnikId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeCenovnika_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Porudzbenice",
                columns: table => new
                {
                    PorudzbenicaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RadnikId = table.Column<int>(type: "int", nullable: false),
                    PIBKupuje = table.Column<int>(type: "int", nullable: false),
                    PIBPrima = table.Column<int>(type: "int", nullable: false),
                    PIBPlaca = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Porudzbenice", x => x.PorudzbenicaId);
                    table.ForeignKey(
                        name: "FK_Porudzbenice_Kupci_PIBKupuje",
                        column: x => x.PIBKupuje,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Porudzbenice_Kupci_PIBPlaca",
                        column: x => x.PIBPlaca,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Porudzbenice_Kupci_PIBPrima",
                        column: x => x.PIBPrima,
                        principalTable: "Kupci",
                        principalColumn: "KupacId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Porudzbenice_Radnici_RadnikId",
                        column: x => x.RadnikId,
                        principalTable: "Radnici",
                        principalColumn: "RadnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeOtpremnice",
                columns: table => new
                {
                    StavkaOtpremniceId = table.Column<int>(type: "int", nullable: false),
                    OtpremnicaId = table.Column<int>(type: "int", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProizvodId = table.Column<int>(type: "int", nullable: false),
                    PorudzbenicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeOtpremnice", x => new { x.StavkaOtpremniceId, x.OtpremnicaId });
                    table.ForeignKey(
                        name: "FK_StavkeOtpremnice_Otpremnice_OtpremnicaId",
                        column: x => x.OtpremnicaId,
                        principalTable: "Otpremnice",
                        principalColumn: "OtpremnicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeOtpremnice_Porudzbenice_PorudzbenicaId",
                        column: x => x.PorudzbenicaId,
                        principalTable: "Porudzbenice",
                        principalColumn: "PorudzbenicaId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_StavkeOtpremnice_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkePorudzbenice",
                columns: table => new
                {
                    StavkaPorudzbeniceId = table.Column<int>(type: "int", nullable: false),
                    PorudzbenicaId = table.Column<int>(type: "int", nullable: false),
                    Kolicina = table.Column<double>(type: "float", nullable: false),
                    DatumIsporuke = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProizvodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkePorudzbenice", x => new { x.StavkaPorudzbeniceId, x.PorudzbenicaId });
                    table.ForeignKey(
                        name: "FK_StavkePorudzbenice_Porudzbenice_PorudzbenicaId",
                        column: x => x.PorudzbenicaId,
                        principalTable: "Porudzbenice",
                        principalColumn: "PorudzbenicaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkePorudzbenice_Proizvodi_ProizvodId",
                        column: x => x.ProizvodId,
                        principalTable: "Proizvodi",
                        principalColumn: "ProizvodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prevozi",
                columns: table => new
                {
                    PrevoznaSredstvaPrevoznoSredstvoId = table.Column<int>(type: "int", nullable: false),
                    StavkePorudzbeniceStavkaPorudzbeniceId = table.Column<int>(type: "int", nullable: false),
                    StavkePorudzbenicePorudzbenicaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prevozi", x => new { x.PrevoznaSredstvaPrevoznoSredstvoId, x.StavkePorudzbeniceStavkaPorudzbeniceId, x.StavkePorudzbenicePorudzbenicaId });
                    table.ForeignKey(
                        name: "FK_Prevozi_PrevoznaSredstva_PrevoznaSredstvaPrevoznoSredstvoId",
                        column: x => x.PrevoznaSredstvaPrevoznoSredstvoId,
                        principalTable: "PrevoznaSredstva",
                        principalColumn: "PrevoznoSredstvoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prevozi_StavkePorudzbenice_StavkePorudzbeniceStavkaPorudzbeniceId_StavkePorudzbenicePorudzbenicaId",
                        columns: x => new { x.StavkePorudzbeniceStavkaPorudzbeniceId, x.StavkePorudzbenicePorudzbenicaId },
                        principalTable: "StavkePorudzbenice",
                        principalColumns: new[] { "StavkaPorudzbeniceId", "PorudzbenicaId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cenovnici_DrzavaId",
                table: "Cenovnici",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cenovnici_RadnikId",
                table: "Cenovnici",
                column: "RadnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Gradovi_DrzavaId",
                table: "Gradovi",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Karatkeristike_ProizvodId",
                table: "Karatkeristike",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_DrzavaId",
                table: "Kupci",
                column: "DrzavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupci_GradId_DrzavaId",
                table: "Kupci",
                columns: new[] { "GradId", "DrzavaId" });

            migrationBuilder.CreateIndex(
                name: "IX_Otpremnice_RadnikId",
                table: "Otpremnice",
                column: "RadnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbenice_PIBKupuje",
                table: "Porudzbenice",
                column: "PIBKupuje");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbenice_PIBPlaca",
                table: "Porudzbenice",
                column: "PIBPlaca");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbenice_PIBPrima",
                table: "Porudzbenice",
                column: "PIBPrima");

            migrationBuilder.CreateIndex(
                name: "IX_Porudzbenice_RadnikId",
                table: "Porudzbenice",
                column: "RadnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Prevozi_StavkePorudzbeniceStavkaPorudzbeniceId_StavkePorudzbenicePorudzbenicaId",
                table: "Prevozi",
                columns: new[] { "StavkePorudzbeniceStavkaPorudzbeniceId", "StavkePorudzbenicePorudzbenicaId" });

            migrationBuilder.CreateIndex(
                name: "IX_StavkeCenovnika_CenovnikId",
                table: "StavkeCenovnika",
                column: "CenovnikId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeCenovnika_ProizvodId",
                table: "StavkeCenovnika",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeOtpremnice_OtpremnicaId",
                table: "StavkeOtpremnice",
                column: "OtpremnicaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeOtpremnice_PorudzbenicaId",
                table: "StavkeOtpremnice",
                column: "PorudzbenicaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeOtpremnice_ProizvodId",
                table: "StavkeOtpremnice",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePorudzbenice_PorudzbenicaId",
                table: "StavkePorudzbenice",
                column: "PorudzbenicaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkePorudzbenice_ProizvodId",
                table: "StavkePorudzbenice",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeReklamacije_ProizvodId",
                table: "StavkeReklamacije",
                column: "ProizvodId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeReklamacije_ReklamacijaId",
                table: "StavkeReklamacije",
                column: "ReklamacijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Karatkeristike");

            migrationBuilder.DropTable(
                name: "Prevozi");

            migrationBuilder.DropTable(
                name: "StavkeCenovnika");

            migrationBuilder.DropTable(
                name: "StavkeOtpremnice");

            migrationBuilder.DropTable(
                name: "StavkeReklamacije");

            migrationBuilder.DropTable(
                name: "PrevoznaSredstva");

            migrationBuilder.DropTable(
                name: "StavkePorudzbenice");

            migrationBuilder.DropTable(
                name: "Cenovnici");

            migrationBuilder.DropTable(
                name: "Otpremnice");

            migrationBuilder.DropTable(
                name: "Reklamacije");

            migrationBuilder.DropTable(
                name: "Porudzbenice");

            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Kupci");

            migrationBuilder.DropTable(
                name: "Radnici");

            migrationBuilder.DropTable(
                name: "Gradovi");

            migrationBuilder.DropTable(
                name: "Drzave");
        }
    }
}
