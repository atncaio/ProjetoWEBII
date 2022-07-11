using Microsoft.EntityFrameworkCore;
using WEBII;

namespace WEBII.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }

        public DbSet<Disciplina>? Disciplina { get; set; }

        public DbSet<WEBII.PreRequisito>? PreRequisito { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=.;Database=WebII;pwd=153624Ca; user id=sa");

        }
    }

    
}
