using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class ProductoCompra
    {
        public int Id { get; set; }
        public int CompraId { get; set; }
        public int ProductoId { get; set; }
        public decimal CantidadDisponible { get; set; }
        public decimal? CostoUnitario { get; set; }
        public decimal? CantidadCompra { get; set; }
        public sbyte? Activa { get; set; }

        public Compras Compra { get; set; }
        public Productos Producto { get; set; }
    }
}
