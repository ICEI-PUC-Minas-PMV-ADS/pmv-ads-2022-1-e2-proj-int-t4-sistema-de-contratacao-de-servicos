using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_contratos_servicos.Migrations
{
    public partial class M06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoServiço",
                table: "Pedidos",
                newName: "TipoServico");

            migrationBuilder.RenameColumn(
                name: "Descrição",
                table: "Pedidos",
                newName: "Descricao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoServico",
                table: "Pedidos",
                newName: "TipoServiço");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Pedidos",
                newName: "Descrição");
        }
    }
}
