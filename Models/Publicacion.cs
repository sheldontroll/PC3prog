using System.Collections.Generic;

namespace PC3prog.Models
{
    public class Publicacion
    {
        public int Id {get;set;}

        public string NombreProducto {get;set;}

        public string Foto {get;set;}

        public string DescripcionPubli {get;set;}

        public string LugarCompra {get;set;}

        public ICollection<Categoria> categorias {get;set;}

    }
}