using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Productoscomplejos
    {
        public Productoscomplejos()
        {
            ProductoProductocomplejo = new HashSet<ProductoProductocomplejo>();
        }

        public int Id { get; set; }
        public int? ProductoId { get; set; }

        public Productos Producto { get; set; }
        public ICollection<ProductoProductocomplejo> ProductoProductocomplejo { get; set; }
    }
}
