using System;

namespace Data.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Modificacion { get; set; }
        public int CategoriaId { get; set; }
    }
}
