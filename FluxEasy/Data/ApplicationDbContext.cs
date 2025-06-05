using FluxEasy.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FluxEasy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        //caso precise apagar
        //Essas linhas de código fazem parte de um DbContext no
        //Entity Framework Core e servem para mapear as tabelas do banco de dados dentro da aplicação ASP.NET Core.
        public DbSet<EstoquePVA> EstoquePVA { get; set; }
        public DbSet<ProdutoAcabado> ProdutoAcabado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProdutoAcabado>().ToTable("ProdutoAcabado");
        }
        //caso precise apagar

    }

}
