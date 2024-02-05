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
            migrationBuilder.DropForeignKey(
                name: "FK_Persoana_Tara_taraid",
                table: "Persoana");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Competitie_competitieid",
                table: "Rezultat");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Persoana_persoanaid",
                table: "Rezultat");

            migrationBuilder.RenameColumn(
                name: "nume",
                table: "Tara",
                newName: "Nume");

            migrationBuilder.RenameColumn(
                name: "iso2",
                table: "Tara",
                newName: "Iso2");

            migrationBuilder.RenameColumn(
                name: "continent",
                table: "Tara",
                newName: "Continent");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tara",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "timp5",
                table: "Rezultat",
                newName: "Timp5");

            migrationBuilder.RenameColumn(
                name: "timp4",
                table: "Rezultat",
                newName: "Timp4");

            migrationBuilder.RenameColumn(
                name: "timp3",
                table: "Rezultat",
                newName: "Timp3");

            migrationBuilder.RenameColumn(
                name: "timp2",
                table: "Rezultat",
                newName: "Timp2");

            migrationBuilder.RenameColumn(
                name: "timp1",
                table: "Rezultat",
                newName: "Timp1");

            migrationBuilder.RenameColumn(
                name: "single",
                table: "Rezultat",
                newName: "Single");

            migrationBuilder.RenameColumn(
                name: "proba",
                table: "Rezultat",
                newName: "Proba");

            migrationBuilder.RenameColumn(
                name: "pozitie",
                table: "Rezultat",
                newName: "Pozitie");

            migrationBuilder.RenameColumn(
                name: "persoanaid",
                table: "Rezultat",
                newName: "PersoanaId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Rezultat",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id_persoana",
                table: "Rezultat",
                newName: "Id_persoana");

            migrationBuilder.RenameColumn(
                name: "id_competitie",
                table: "Rezultat",
                newName: "Id_competitie");

            migrationBuilder.RenameColumn(
                name: "competitieid",
                table: "Rezultat",
                newName: "CompetitieId");

            migrationBuilder.RenameColumn(
                name: "average",
                table: "Rezultat",
                newName: "Average");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Rezultat",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Rezultat_persoanaid",
                table: "Rezultat",
                newName: "IX_Rezultat_PersoanaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezultat_competitieid",
                table: "Rezultat",
                newName: "IX_Rezultat_CompetitieId");

            migrationBuilder.RenameColumn(
                name: "taraid",
                table: "Persoana",
                newName: "TaraId");

            migrationBuilder.RenameColumn(
                name: "nume",
                table: "Persoana",
                newName: "Nume");

            migrationBuilder.RenameColumn(
                name: "id_tara",
                table: "Persoana",
                newName: "Id_tara");

            migrationBuilder.RenameColumn(
                name: "data_nasterii",
                table: "Persoana",
                newName: "Data_nasterii");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Persoana",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Persoana_taraid",
                table: "Persoana",
                newName: "IX_Persoana_TaraId");

            migrationBuilder.RenameColumn(
                name: "oras",
                table: "Competitie",
                newName: "Oras");

            migrationBuilder.RenameColumn(
                name: "nume",
                table: "Competitie",
                newName: "Nume");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Competitie",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Competitie",
                newName: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_ContWCA_Id_persoana",
                table: "ContWCA",
                column: "Id_persoana",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Persoana_Tara_TaraId",
                table: "Persoana",
                column: "TaraId",
                principalTable: "Tara",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Competitie_CompetitieId",
                table: "Rezultat",
                column: "CompetitieId",
                principalTable: "Competitie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Persoana_PersoanaId",
                table: "Rezultat",
                column: "PersoanaId",
                principalTable: "Persoana",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persoana_Tara_TaraId",
                table: "Persoana");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Competitie_CompetitieId",
                table: "Rezultat");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Persoana_PersoanaId",
                table: "Rezultat");

            migrationBuilder.DropTable(
                name: "ContWCA");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Tara",
                newName: "nume");

            migrationBuilder.RenameColumn(
                name: "Iso2",
                table: "Tara",
                newName: "iso2");

            migrationBuilder.RenameColumn(
                name: "Continent",
                table: "Tara",
                newName: "continent");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tara",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Timp5",
                table: "Rezultat",
                newName: "timp5");

            migrationBuilder.RenameColumn(
                name: "Timp4",
                table: "Rezultat",
                newName: "timp4");

            migrationBuilder.RenameColumn(
                name: "Timp3",
                table: "Rezultat",
                newName: "timp3");

            migrationBuilder.RenameColumn(
                name: "Timp2",
                table: "Rezultat",
                newName: "timp2");

            migrationBuilder.RenameColumn(
                name: "Timp1",
                table: "Rezultat",
                newName: "timp1");

            migrationBuilder.RenameColumn(
                name: "Single",
                table: "Rezultat",
                newName: "single");

            migrationBuilder.RenameColumn(
                name: "Proba",
                table: "Rezultat",
                newName: "proba");

            migrationBuilder.RenameColumn(
                name: "Pozitie",
                table: "Rezultat",
                newName: "pozitie");

            migrationBuilder.RenameColumn(
                name: "PersoanaId",
                table: "Rezultat",
                newName: "persoanaid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Rezultat",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id_persoana",
                table: "Rezultat",
                newName: "id_persoana");

            migrationBuilder.RenameColumn(
                name: "Id_competitie",
                table: "Rezultat",
                newName: "id_competitie");

            migrationBuilder.RenameColumn(
                name: "CompetitieId",
                table: "Rezultat",
                newName: "competitieid");

            migrationBuilder.RenameColumn(
                name: "Average",
                table: "Rezultat",
                newName: "average");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rezultat",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Rezultat_PersoanaId",
                table: "Rezultat",
                newName: "IX_Rezultat_persoanaid");

            migrationBuilder.RenameIndex(
                name: "IX_Rezultat_CompetitieId",
                table: "Rezultat",
                newName: "IX_Rezultat_competitieid");

            migrationBuilder.RenameColumn(
                name: "TaraId",
                table: "Persoana",
                newName: "taraid");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Persoana",
                newName: "nume");

            migrationBuilder.RenameColumn(
                name: "Id_tara",
                table: "Persoana",
                newName: "id_tara");

            migrationBuilder.RenameColumn(
                name: "Data_nasterii",
                table: "Persoana",
                newName: "data_nasterii");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Persoana",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Persoana_TaraId",
                table: "Persoana",
                newName: "IX_Persoana_taraid");

            migrationBuilder.RenameColumn(
                name: "Oras",
                table: "Competitie",
                newName: "oras");

            migrationBuilder.RenameColumn(
                name: "Nume",
                table: "Competitie",
                newName: "nume");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Competitie",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Competitie",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persoana_Tara_taraid",
                table: "Persoana",
                column: "taraid",
                principalTable: "Tara",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Competitie_competitieid",
                table: "Rezultat",
                column: "competitieid",
                principalTable: "Competitie",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Persoana_persoanaid",
                table: "Rezultat",
                column: "persoanaid",
                principalTable: "Persoana",
                principalColumn: "id");
        }
    }
}
