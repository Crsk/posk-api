using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            PedidosProductos = new HashSet<PedidosProductos>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string Mensaje { get; set; }
        public int? UsuarioId { get; set; }
        public int? MesaId { get; set; }
        public sbyte? Pagado { get; set; }

        public Mesas Mesa { get; set; }
        public Usuarios Usuario { get; set; }
        public ICollection<PedidosProductos> PedidosProductos { get; set; }
    }
}
