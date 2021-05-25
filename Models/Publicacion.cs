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

        public string Precio {get;set;}

        public Categoria Categoria {get;set;}

        public int CategoriaId {get;set;}
        
    }
}