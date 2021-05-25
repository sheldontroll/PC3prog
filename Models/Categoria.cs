using System.Collections.Generic;

namespace PC3prog.Models
{
    public class Categoria
    {
        public int Id {get;set;}

        public string Nombre {get;set;}

        public ICollection<Publicacion> Publicaciones {get;set;}


    }
}