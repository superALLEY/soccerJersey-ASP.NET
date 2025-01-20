using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Football.Migrations
{
    /// <inheritdoc />
    public partial class MaNouvelleMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Equipe",
                table: "Maillots",
                newName: "Pays");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pays",
                table: "Maillots",
                newName: "Equipe");
        }
    }
}
