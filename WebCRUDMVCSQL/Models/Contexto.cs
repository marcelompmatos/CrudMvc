using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQL.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Tipo_Produto> Tipo_Produto { get; set; }

    }
}
