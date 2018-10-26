using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class DetalleBoleta
    {
        public DetalleBoleta()
        {
            VentasJornada = new HashSet<VentasJornada>();
        }

        public int Id { get; set; }
        public int? Monto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Descuento { get; set; }
        public int? ProductoId { get; set; }
        public int BoletaId { get; set; }
        public int? PromocionId { get; set; }

        public Boletas Boleta { get; set; }
        public Productos Producto { get; set; }
        public Promociones Promocion { get; set; }
        public ICollection<VentasJornada> VentasJornada { get; set; }
    }
}
