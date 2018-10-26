using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class LineasFiado
    {
        public int Id { get; set; }
        public int? Monto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public int? ProductoId { get; set; }
        public int? FiadoId { get; set; }

        public Fiados Fiado { get; set; }
        public Productos Producto { get; set; }
    }
}
