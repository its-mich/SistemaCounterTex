using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaCounterTex.Migrations
{
    /// <inheritdoc />
    public partial class ContextoCompleto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecioPrenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoPrenda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    NombreProveedor = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Localidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Barrio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadPrendas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Registro",
                columns: table => new
                {
                    IdRegistro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ConfirmarContraseña = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registro", x => x.IdRegistro);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreUsuario = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "PerfilAdministrador",
                columns: table => new
                {
                    IdAdministrador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreAdministrador = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProduccionDiaria = table.Column<int>(type: "int", nullable: false),
                    ProduccionMensual = table.Column<int>(type: "int", nullable: false),
                    ControlPrendas = table.Column<int>(type: "int", nullable: false),
                    Registro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ganancias = table.Column<int>(type: "int", nullable: false),
                    Pagos = table.Column<int>(type: "int", nullable: false),
                    Gastos = table.Column<int>(type: "int", nullable: false),
                    MetaPorCorte = table.Column<int>(type: "int", nullable: false),
                    ConsultarInformacion = table.Column<bool>(type: "bit", nullable: false),
                    ControlHorarios = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatInterno = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BotonAyuda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilAdministrador", x => x.IdAdministrador);
                    table.ForeignKey(
                        name: "FK_PerfilAdministrador_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerfilEmpleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduccionDiaria = table.Column<int>(type: "int", nullable: false),
                    TipoPrenda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TipoOperacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantidadOperacion = table.Column<int>(type: "int", nullable: false),
                    ValorOperacion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConsultarInformacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ControlHorarios = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraEntrada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MetaPorCorte = table.Column<int>(type: "int", nullable: false),
                    BotonAyuda = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Estadisticas = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilEmpleado", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_PerfilEmpleado_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Satelite",
                columns: table => new
                {
                    SateliteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fabricante = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PagoPrendas = table.Column<int>(type: "int", nullable: false),
                    Ganancias = table.Column<int>(type: "int", nullable: false),
                    Operacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PagoOperacion = table.Column<int>(type: "int", nullable: false),
                    TipoMaquina = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Inventariomaquinas = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdProveedor = table.Column<int>(type: "int", nullable: false),
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satelite", x => x.SateliteId);
                    table.ForeignKey(
                        name: "FK_Satelite_Usuario_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "Usuario",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PerfilAdministrador_IdUsuario",
                table: "PerfilAdministrador",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PerfilEmpleado_IdUsuario",
                table: "PerfilEmpleado",
                column: "IdUsuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Satelite_IdUsuario",
                table: "Satelite",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PerfilAdministrador");

            migrationBuilder.DropTable(
                name: "PerfilEmpleado");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Registro");

            migrationBuilder.DropTable(
                name: "Satelite");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
