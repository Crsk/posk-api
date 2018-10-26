using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class PedidosProductos
    {
        public PedidosProductos()
        {
            PedidosAgregados = new HashSet<PedidosAgregados>();
            PedidosPreparaciones = new HashSet<PedidosPreparaciones>();
        }

        public int Id { get; set; }
        public decimal? Cantidad { get; set; }
        public int? PedidoId { get; set; }
        public int? ProductoId { get; set; }
        public sbyte? Impreso { get; set; }
        public decimal? ImpresoCantidad { get; set; }
        public int? PromoId { get; set; }
        public int Precio { get; set; }
        public string Nota { get; set; }

        public Pedidos Pedido { get; set; }
        public Productos Producto { get; set; }
        public Promociones Promo { get; set; }
        public ICollection<PedidosAgregados> PedidosAgregados { get; set; }
        public ICollection<PedidosPreparaciones> PedidosPreparaciones { get; set; }
    }
}
