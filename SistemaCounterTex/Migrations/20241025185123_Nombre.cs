using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaCounterTex.Migrations
{
    /// <inheritdoc />
    public partial class Nombre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Contrasena",
                table: "Registros",
                newName: "Clave");

            migrationBuilder.AddColumn<string>(
                name: "NombreCompleto",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreCompleto",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Clave",
                table: "Registros",
                newName: "Contrasena");
        }
    }
}
