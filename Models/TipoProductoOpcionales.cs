using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class TipoProductoOpcionales
    {
        public int Id { get; set; }
        public int TipoProductoId { get; set; }
        public int OpcionalId { get; set; }

        public Opcionales Opcional { get; set; }
        public TipoProducto TipoProducto { get; set; }
    }
}
