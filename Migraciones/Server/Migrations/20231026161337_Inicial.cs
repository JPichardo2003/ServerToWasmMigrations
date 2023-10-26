using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migraciones.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Teléfono = table.Column<string>(type: "TEXT", nullable: false),
                    Celular = table.Column<string>(type: "TEXT", nullable: false),
                    Rnc = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Dirección = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Prioridades",
                columns: table => new
                {
                    PrioridadId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false),
                    DiasCompromiso = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prioridades", x => x.PrioridadId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    PrioridadId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Asunto = table.Column<string>(type: "TEXT", nullable: false),
                    Descripción = table.Column<string>(type: "TEXT", nullable: false),
                    SolicitadoPor = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Prioridades_PrioridadId",
                        column: x => x.PrioridadId,
                        principalTable: "Prioridades",
                        principalColumn: "PrioridadId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClienteId",
                table: "Tickets",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PrioridadId",
                table: "Tickets",
                column: "PrioridadId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Prioridades");
        }
    }
}
