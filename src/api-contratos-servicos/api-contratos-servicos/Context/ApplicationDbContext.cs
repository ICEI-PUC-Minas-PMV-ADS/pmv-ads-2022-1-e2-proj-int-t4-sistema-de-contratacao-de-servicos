using api_contratos_servicos.Models;
using Microsoft.EntityFrameworkCore;

namespace api_contratos_servicos.Context
{
    public class ApplicationDbContext:  DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario>? Usuarios { get; set; }

        public DbSet<Cliente>? clientes { get; set; }

        public DbSet<Fornecedor>? Fornecedores { get; set; }

        public DbSet<api_contratos_servicos.Models.Pedido>? Pedido { get; set; }
    }
}
