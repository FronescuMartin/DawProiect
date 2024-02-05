using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContWCA_Persoana_Id_persoana",
                table: "ContWCA");

            migrationBuilder.DropForeignKey(
                name: "FK_Persoana_Tara_TaraId",
                table: "Persoana");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Competitie_Id_competitie",
                table: "Rezultat");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Persoana_Id_persoana",
                table: "Rezultat");

            migrationBuilder.DropColumn(
                name: "Id_tara",
                table: "Persoana");

            migrationBuilder.RenameColumn(
                name: "Id_competitie",
                table: "Rezultat",
                newName: "CompetitieId");

            migrationBuilder.RenameColumn(
                name: "Id_persoana",
                table: "Rezultat",
                newName: "PersoanaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rezultat_Id_competitie",
                table: "Rezultat",
                newName: "IX_Rezultat_CompetitieId");

            migrationBuilder.RenameColumn(
                name: "Id_persoana",
                table: "ContWCA",
                newName: "PersoanaId");

            migrationBuilder.RenameIndex(
                name: "IX_ContWCA_Id_persoana",
                table: "ContWCA",
                newName: "IX_ContWCA_PersoanaId");

            migrationBuilder.AlterColumn<int>(
                name: "TaraId",
                table: "Persoana",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ContWCA_Persoana_PersoanaId",
                table: "ContWCA",
                column: "PersoanaId",
                principalTable: "Persoana",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persoana_Tara_TaraId",
                table: "Persoana",
                column: "TaraId",
                principalTable: "Tara",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Competitie_CompetitieId",
                table: "Rezultat",
                column: "CompetitieId",
                principalTable: "Competitie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Persoana_PersoanaId",
                table: "Rezultat",
                column: "PersoanaId",
                principalTable: "Persoana",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContWCA_Persoana_PersoanaId",
                table: "ContWCA");

            migrationBuilder.DropForeignKey(
                name: "FK_Persoana_Tara_TaraId",
                table: "Persoana");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Competitie_CompetitieId",
                table: "Rezultat");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezultat_Persoana_PersoanaId",
                table: "Rezultat");

            migrationBuilder.RenameColumn(
                name: "CompetitieId",
                table: "Rezultat",
                newName: "Id_competitie");

            migrationBuilder.RenameColumn(
                name: "PersoanaId",
                table: "Rezultat",
                newName: "Id_persoana");

            migrationBuilder.RenameIndex(
                name: "IX_Rezultat_CompetitieId",
                table: "Rezultat",
                newName: "IX_Rezultat_Id_competitie");

            migrationBuilder.RenameColumn(
                name: "PersoanaId",
                table: "ContWCA",
                newName: "Id_persoana");

            migrationBuilder.RenameIndex(
                name: "IX_ContWCA_PersoanaId",
                table: "ContWCA",
                newName: "IX_ContWCA_Id_persoana");

            migrationBuilder.AlterColumn<int>(
                name: "TaraId",
                table: "Persoana",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id_tara",
                table: "Persoana",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_ContWCA_Persoana_Id_persoana",
                table: "ContWCA",
                column: "Id_persoana",
                principalTable: "Persoana",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persoana_Tara_TaraId",
                table: "Persoana",
                column: "TaraId",
                principalTable: "Tara",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Competitie_Id_competitie",
                table: "Rezultat",
                column: "Id_competitie",
                principalTable: "Competitie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezultat_Persoana_Id_persoana",
                table: "Rezultat",
                column: "Id_persoana",
                principalTable: "Persoana",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
