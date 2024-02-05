using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tara",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iso2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Continent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tara", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persoana",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_nasterii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaraId = table.Column<int>(type: "int", nullable: true),
                    Id_tara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoana", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persoana_Tara_TaraId",
                        column: x => x.TaraId,
                        principalTable: "Tara",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ContWCA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wca_id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_crearii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_persoana = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContWCA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContWCA_Persoana_Id_persoana",
                        column: x => x.Id_persoana,
                        principalTable: "Persoana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezultat",
                columns: table => new
                {
                    Id_competitie = table.Column<int>(type: "int", nullable: false),
                    Id_persoana = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Proba = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pozitie = table.Column<int>(type: "int", nullable: false),
                    Timp1 = table.Column<double>(type: "float", nullable: false),
                    Timp2 = table.Column<double>(type: "float", nullable: false),
                    Timp3 = table.Column<double>(type: "float", nullable: false),
                    Timp4 = table.Column<double>(type: "float", nullable: false),
                    Timp5 = table.Column<double>(type: "float", nullable: false),
                    Single = table.Column<double>(type: "float", nullable: false),
                    Average = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezultat", x => new { x.Id_persoana, x.Id_competitie });
                    table.ForeignKey(
                        name: "FK_Rezultat_Competitie_Id_competitie",
                        column: x => x.Id_competitie,
                        principalTable: "Competitie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezultat_Persoana_Id_persoana",
                        column: x => x.Id_persoana,
                        principalTable: "Persoana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContWCA_Id_persoana",
                table: "ContWCA",
                column: "Id_persoana",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persoana_TaraId",
                table: "Persoana",
                column: "TaraId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezultat_Id_competitie",
                table: "Rezultat",
                column: "Id_competitie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContWCA");

            migrationBuilder.DropTable(
                name: "Rezultat");

            migrationBuilder.DropTable(
                name: "Competitie");

            migrationBuilder.DropTable(
                name: "Persoana");

            migrationBuilder.DropTable(
                name: "Tara");
        }
    }
}
