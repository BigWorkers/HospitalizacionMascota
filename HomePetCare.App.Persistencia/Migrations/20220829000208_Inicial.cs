using Microsoft.EntityFrameworkCore.Migrations;

namespace HomePetCare.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Formulas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropietariosMascotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropietariosMascotas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recomendacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VeterinariosDomiciliarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TarjetaProfesional = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeterinariosDomiciliarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportesVisitas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaRespiratoria = table.Column<int>(type: "int", nullable: false),
                    FrecuenciaCardiaca = table.Column<int>(type: "int", nullable: false),
                    EstadoDeAnimo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaVisita = table.Column<int>(type: "int", nullable: false),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    RecomendacionId = table.Column<int>(type: "int", nullable: true),
                    FormulasId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportesVisitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportesVisitas_Formulas_FormulasId",
                        column: x => x.FormulasId,
                        principalTable: "Formulas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportesVisitas_Recomendacion_RecomendacionId",
                        column: x => x.RecomendacionId,
                        principalTable: "Recomendacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReportesVisitas_VeterinariosDomiciliarios_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "VeterinariosDomiciliarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mascotas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnoNacimiento = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoSalud = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MedicoId = table.Column<int>(type: "int", nullable: true),
                    DeuñoPerroId = table.Column<int>(type: "int", nullable: true),
                    ReporteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascotas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascotas_PropietariosMascotas_DeuñoPerroId",
                        column: x => x.DeuñoPerroId,
                        principalTable: "PropietariosMascotas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_ReportesVisitas_ReporteId",
                        column: x => x.ReporteId,
                        principalTable: "ReportesVisitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mascotas_VeterinariosDomiciliarios_MedicoId",
                        column: x => x.MedicoId,
                        principalTable: "VeterinariosDomiciliarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_DeuñoPerroId",
                table: "Mascotas",
                column: "DeuñoPerroId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_MedicoId",
                table: "Mascotas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascotas_ReporteId",
                table: "Mascotas",
                column: "ReporteId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportesVisitas_FormulasId",
                table: "ReportesVisitas",
                column: "FormulasId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportesVisitas_MedicoId",
                table: "ReportesVisitas",
                column: "MedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportesVisitas_RecomendacionId",
                table: "ReportesVisitas",
                column: "RecomendacionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mascotas");

            migrationBuilder.DropTable(
                name: "PropietariosMascotas");

            migrationBuilder.DropTable(
                name: "ReportesVisitas");

            migrationBuilder.DropTable(
                name: "Formulas");

            migrationBuilder.DropTable(
                name: "Recomendacion");

            migrationBuilder.DropTable(
                name: "VeterinariosDomiciliarios");
        }
    }
}
