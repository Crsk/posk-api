using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class DeliveryItem
    {
        public int Id { get; set; }
        public string Direccion { get; set; }
        public string NombreCliente { get; set; }
        public int? ClienteId { get; set; }
        public string Comentario { get; set; }
        public string Incluye { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public DateTime FechaPedido { get; set; }
        public int? BoletaId { get; set; }
        public sbyte? Servir { get; set; }
        public int PagaCon { get; set; }
        public string Vuelto { get; set; }
        public int? MedioPagoId { get; set; }

        public Boletas Boleta { get; set; }
        public Clientes Cliente { get; set; }
        public MedioPago MedioPago { get; set; }
    }
}
