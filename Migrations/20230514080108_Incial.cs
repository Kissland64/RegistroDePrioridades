using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Registro_de_prioridades.Migrations
{
    /// <inheritdoc />
    public partial class Incial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prioridades",
                columns: table => new
                {
                    PrioridadesId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridades", x => x.PrioridadesId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prioridades");
        }
    }
}
