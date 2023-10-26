using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migraciones.Server.Migrations
{
    /// <inheritdoc />
    public partial class _2damigraciondebidoacambiosenelmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Prioridades",
                newName: "Descripción");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripción",
                table: "Prioridades",
                newName: "Descripcion");
        }
    }
}
