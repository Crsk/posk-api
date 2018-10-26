using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class TipoProducto
    {
        public TipoProducto()
        {
            Productos = new HashSet<Productos>();
            TipoProductoOpcionales = new HashSet<TipoProductoOpcionales>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int LimiteIngr { get; set; }
        public sbyte MostrarOpciones { get; set; }

        public ICollection<Productos> Productos { get; set; }
        public ICollection<TipoProductoOpcionales> TipoProductoOpcionales { get; set; }
    }
}
