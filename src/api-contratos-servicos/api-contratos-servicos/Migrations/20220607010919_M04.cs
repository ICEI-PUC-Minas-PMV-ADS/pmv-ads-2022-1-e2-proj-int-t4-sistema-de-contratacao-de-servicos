using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_contratos_servicos.Migrations
{
    public partial class M04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Orcamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorEstimadoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataAprovacaoOrcamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataConclusaoDoServico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servico", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "servico");
        }
    }
}
