using Microsoft.EntityFrameworkCore.Migrations;

namespace API_PRUEBA.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    idUsuarioCreacion = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    id = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    idUsuarioCreacion = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    usuario = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    primerNombre = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    segundoNombre = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    primerApellido = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    segundoApellido = table.Column<string>(unicode: false, maxLength: 80, nullable: false),
                    idDepartamento = table.Column<decimal>(type: "numeric(18, 0)", nullable: false),
                    idCargo = table.Column<decimal>(type: "numeric(18, 0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_Usuario", x => x.usuario);
                    table.ForeignKey(
                        name: "FK__Users__idCargo__286302EC",
                        column: x => x.idCargo,
                        principalTable: "Cargos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Users__idDeparta__276EDEB3",
                        column: x => x.idDepartamento,
                        principalTable: "Departamentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_idCargo",
                table: "Users",
                column: "idCargo");

            migrationBuilder.CreateIndex(
                name: "IX_Users_idDepartamento",
                table: "Users",
                column: "idDepartamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
