using Microsoft.EntityFrameworkCore;

namespace crudmvc.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options ) : base(options)
        { 
            
        }

        public DbSet<Profissional> Profissional { get; set; }
    }
}
