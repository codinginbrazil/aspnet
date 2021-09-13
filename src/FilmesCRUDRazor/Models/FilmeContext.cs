//Contexto para criacao da tabela
using Microsoft.EntifyFrameworkCore;

namespace FilmesCRUDRazor.Models
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options)
            : base(options)
        {
            //Default
        }

        public DbSet<Filme> Filme { get; set; }
                            
    }
}