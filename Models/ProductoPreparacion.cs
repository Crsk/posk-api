using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class ProductoPreparacion
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public int? PreparacionId { get; set; }

        public Preparaciones Preparacion { get; set; }
        public Productos Producto { get; set; }
    }
}
