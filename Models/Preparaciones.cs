using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Preparaciones
    {
        public Preparaciones()
        {
            PedidosPreparaciones = new HashSet<PedidosPreparaciones>();
            ProductoPreparacion = new HashSet<ProductoPreparacion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int FontSize { get; set; }

        public ICollection<PedidosPreparaciones> PedidosPreparaciones { get; set; }
        public ICollection<ProductoPreparacion> ProductoPreparacion { get; set; }
    }
}
