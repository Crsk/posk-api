using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Promociones
    {
        public Promociones()
        {
            DetalleBoleta = new HashSet<DetalleBoleta>();
            PedidosProductos = new HashSet<PedidosProductos>();
            Pendientes = new HashSet<Pendientes>();
            ProductoPromocion = new HashSet<ProductoPromocion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Precio { get; set; }
        public string Imagen { get; set; }
        public int? SubcategoriaId { get; set; }
        public sbyte? Favorito { get; set; }

        public Subcategorias Subcategoria { get; set; }
        public ICollection<DetalleBoleta> DetalleBoleta { get; set; }
        public ICollection<PedidosProductos> PedidosProductos { get; set; }
        public ICollection<Pendientes> Pendientes { get; set; }
        public ICollection<ProductoPromocion> ProductoPromocion { get; set; }
    }
}
