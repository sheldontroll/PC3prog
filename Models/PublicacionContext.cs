using Microsoft.EntityFrameworkCore;

namespace PC3prog.Models
{
    public class PublicacionContext : DbContext
    {
        public DbSet<Categoria> Categorias {get;set;}

        public DbSet<Publicacion> Publicaciones {get;set;}

        public PublicacionContext(DbContextOptions dco ) : base(dco){
            
        }
    }
}