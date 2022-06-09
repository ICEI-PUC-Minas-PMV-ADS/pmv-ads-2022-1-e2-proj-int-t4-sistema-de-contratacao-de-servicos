using api_terceirizados.Models;
using Microsoft.EntityFrameworkCore;


namespace api_terceirizados.Context
{
    public class ApplicationDbContext:  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }

        public DbSet<Cliente>? Clientes { get; set; }

        public DbSet<Fornecedor>? Fornecedores { get; set; }

        public DbSet<Pedido>? Pedidos { get; set; }

        public DbSet<Orcamento>? Orcamentos { get; set; }

        public DbSet<TipoServico>? TipoServicos { get; set; }

        public DbSet<Servico>? Servicos { get; set; }
    }
}
