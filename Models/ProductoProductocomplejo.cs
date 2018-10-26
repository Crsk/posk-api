using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class ProductoProductocomplejo
    {
        public int Id { get; set; }
        public int? ProductocomplejoId { get; set; }
        public int? ProductoId { get; set; }
        public decimal? Cantidad { get; set; }

        public Productos Producto { get; set; }
        public Productoscomplejos Productocomplejo { get; set; }
    }
}
