using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class PedidosPreparaciones
    {
        public int Id { get; set; }
        public int? PedidosProductosId { get; set; }
        public int? PreparacionId { get; set; }

        public PedidosProductos PedidosProductos { get; set; }
        public Preparaciones Preparacion { get; set; }
    }
}
