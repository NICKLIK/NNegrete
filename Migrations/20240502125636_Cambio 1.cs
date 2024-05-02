using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NNegrete.Migrations
{
    public partial class Cambio1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    IdCarrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_carrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Campus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero_semestres = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.IdCarrera);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    IdBanner = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Promedio = table.Column<float>(type: "real", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Matriculado = table.Column<bool>(type: "bit", nullable: false),
                    IdCarrera = table.Column<int>(type: "int", nullable: false),
                    CarreraIdCarrera = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.IdBanner);
                    table.ForeignKey(
                        name: "FK_Estudiante_Carrera_CarreraIdCarrera",
                        column: x => x.CarreraIdCarrera,
                        principalTable: "Carrera",
                        principalColumn: "IdCarrera",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estudiante_CarreraIdCarrera",
                table: "Estudiante",
                column: "CarreraIdCarrera");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estudiante");

            migrationBuilder.DropTable(
                name: "Carrera");
        }
    }
}
