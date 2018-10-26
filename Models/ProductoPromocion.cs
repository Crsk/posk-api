using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class ProductoPromocion
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public int? PromocionId { get; set; }

        public Productos Producto { get; set; }
        public Promociones Promocion { get; set; }
    }
}
