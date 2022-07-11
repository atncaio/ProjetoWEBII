using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEBII.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "disciplinas",
            //    columns: table => new
            //    {
            //        disciplina_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        disciplina_nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        disciplina_periodo = table.Column<int>(type: "int", nullable: false),
            //        disciplina_categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        disciplina_dificuldade = table.Column<double>(type: "float", nullable: false),
            //        disciplina_creditos = table.Column<int>(type: "int", nullable: false),
            //        disciplina_horaAula = table.Column<int>(type: "int", nullable: false),
            //        disciplina_horaRelogio = table.Column<int>(type: "int", nullable: false),
            //        disciplina_qtdTeorica = table.Column<int>(type: "int", nullable: false),
            //        disciplina_qtdPratica = table.Column<int>(type: "int", nullable: false),
            //        disciplina_ementa = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_disciplinas", x => x.disciplina_id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "prerequisitos",
            //    columns: table => new
            //    {
            //        requisitos_id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        disciplina_id = table.Column<int>(type: "int", nullable: false),
            //        disciplina_nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        requisitos_disciplina = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        requisitos_creditos = table.Column<int>(type: "int", nullable: false),
            //        requisitos_periodo = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_prerequisitos", x => x.requisitos_id);
            //    });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "disciplinas");

            migrationBuilder.DropTable(
                name: "prerequisitos");
        }
    }
}
