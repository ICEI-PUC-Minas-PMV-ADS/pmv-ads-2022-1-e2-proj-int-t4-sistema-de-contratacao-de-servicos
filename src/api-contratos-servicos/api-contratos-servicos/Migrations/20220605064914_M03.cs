using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_contratos_servicos.Migrations
{
    public partial class M03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_usuarios_UsuarioId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_usuarios_UsuarioId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_UsuarioId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoServiço = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrição = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                });

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
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "servico");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_UsuarioId",
                table: "Fornecedores",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_usuarios_UsuarioId",
                table: "Clientes",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_usuarios_UsuarioId",
                table: "Fornecedores",
                column: "UsuarioId",
                principalTable: "usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
