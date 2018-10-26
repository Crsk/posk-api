using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Boletas
    {
        public Boletas()
        {
            BoletaMediopago = new HashSet<BoletaMediopago>();
            DeliveryItem = new HashSet<DeliveryItem>();
            DetalleBoleta = new HashSet<DetalleBoleta>();
        }

        public int Id { get; set; }
        public int? NumeroBoleta { get; set; }
        public DateTime Fecha { get; set; }
        public int? PuntosCantidad { get; set; }
        public int? Total { get; set; }
        public int? ClienteId { get; set; }
        public int? UsuarioId { get; set; }
        public int Propina { get; set; }

        public Clientes Cliente { get; set; }
        public Usuarios Usuario { get; set; }
        public ICollection<BoletaMediopago> BoletaMediopago { get; set; }
        public ICollection<DeliveryItem> DeliveryItem { get; set; }
        public ICollection<DetalleBoleta> DetalleBoleta { get; set; }
    }
}
