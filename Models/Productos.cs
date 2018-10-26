using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Productos
    {
        public Productos()
        {
            BodegaMovimiento = new HashSet<BodegaMovimiento>();
            BodegaStock = new HashSet<BodegaStock>();
            DetalleBoleta = new HashSet<DetalleBoleta>();
            Deudas = new HashSet<Deudas>();
            Devolucion = new HashSet<Devolucion>();
            Envolturas = new HashSet<Envolturas>();
            LineasFiado = new HashSet<LineasFiado>();
            Mermas = new HashSet<Mermas>();
            PedidosProductos = new HashSet<PedidosProductos>();
            Pendientes = new HashSet<Pendientes>();
            ProductoCompra = new HashSet<ProductoCompra>();
            ProductoMateriaprima = new HashSet<ProductoMateriaprima>();
            ProductoPreparacion = new HashSet<ProductoPreparacion>();
            ProductoProductocomplejo = new HashSet<ProductoProductocomplejo>();
            ProductoPromocion = new HashSet<ProductoPromocion>();
            Productoscomplejos = new HashSet<Productoscomplejos>();
            StockPr = new HashSet<StockPr>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoBarras { get; set; }
        public int Precio { get; set; }
        public sbyte? Retornable { get; set; }
        public sbyte? Favorito { get; set; }
        public int? PuntosCantidad { get; set; }
        public string Imagen { get; set; }
        public int? SubCategoriaId { get; set; }
        public sbyte? SoloVenta { get; set; }
        public sbyte? SoloCompra { get; set; }
        public int? SectorImpresionId { get; set; }
        public int ZIndex { get; set; }
        public int? TipoProductoId { get; set; }

        public SectorImpresion SectorImpresion { get; set; }
        public Subcategorias SubCategoria { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public ICollection<BodegaMovimiento> BodegaMovimiento { get; set; }
        public ICollection<BodegaStock> BodegaStock { get; set; }
        public ICollection<DetalleBoleta> DetalleBoleta { get; set; }
        public ICollection<Deudas> Deudas { get; set; }
        public ICollection<Devolucion> Devolucion { get; set; }
        public ICollection<Envolturas> Envolturas { get; set; }
        public ICollection<LineasFiado> LineasFiado { get; set; }
        public ICollection<Mermas> Mermas { get; set; }
        public ICollection<PedidosProductos> PedidosProductos { get; set; }
        public ICollection<Pendientes> Pendientes { get; set; }
        public ICollection<ProductoCompra> ProductoCompra { get; set; }
        public ICollection<ProductoMateriaprima> ProductoMateriaprima { get; set; }
        public ICollection<ProductoPreparacion> ProductoPreparacion { get; set; }
        public ICollection<ProductoProductocomplejo> ProductoProductocomplejo { get; set; }
        public ICollection<ProductoPromocion> ProductoPromocion { get; set; }
        public ICollection<Productoscomplejos> Productoscomplejos { get; set; }
        public ICollection<StockPr> StockPr { get; set; }
    }
}
