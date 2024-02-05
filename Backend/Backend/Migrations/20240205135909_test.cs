using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competitie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    oras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competitie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tara",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    iso2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    continent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tara", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Persoana",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_nasterii = table.Column<DateTime>(type: "datetime2", nullable: false),
                    taraid = table.Column<int>(type: "int", nullable: true),
                    id_tara = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persoana", x => x.id);
                    table.ForeignKey(
                        name: "FK_Persoana_Tara_taraid",
                        column: x => x.taraid,
                        principalTable: "Tara",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Rezultat",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    proba = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pozitie = table.Column<int>(type: "int", nullable: false),
                    timp1 = table.Column<double>(type: "float", nullable: false),
                    timp2 = table.Column<double>(type: "float", nullable: false),
                    timp3 = table.Column<double>(type: "float", nullable: false),
                    timp4 = table.Column<double>(type: "float", nullable: false),
                    timp5 = table.Column<double>(type: "float", nullable: false),
                    single = table.Column<double>(type: "float", nullable: false),
                    average = table.Column<double>(type: "float", nullable: false),
                    competitieid = table.Column<int>(type: "int", nullable: true),
                    id_competitie = table.Column<int>(type: "int", nullable: false),
                    persoanaid = table.Column<int>(type: "int", nullable: true),
                    id_persoana = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezultat", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rezultat_Competitie_competitieid",
                        column: x => x.competitieid,
                        principalTable: "Competitie",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Rezultat_Persoana_persoanaid",
                        column: x => x.persoanaid,
                        principalTable: "Persoana",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persoana_taraid",
                table: "Persoana",
                column: "taraid");

            migrationBuilder.CreateIndex(
                name: "IX_Rezultat_competitieid",
                table: "Rezultat",
                column: "competitieid");

            migrationBuilder.CreateIndex(
                name: "IX_Rezultat_persoanaid",
                table: "Rezultat",
                column: "persoanaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
