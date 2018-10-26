using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Compras
    {
        public Compras()
        {
            ProductoCompra = new HashSet<ProductoCompra>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int UsuarioId { get; set; }

        public Usuarios Usuario { get; set; }
        public ICollection<ProductoCompra> ProductoCompra { get; set; }
    }
}
