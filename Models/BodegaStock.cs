using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class BodegaStock
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public decimal? Stock { get; set; }

        public Productos Producto { get; set; }
    }
}
