using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Puntos
    {
        public Puntos()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int Id { get; set; }
        public int? PuntosActivos { get; set; }
        public int? PuntosExpirados { get; set; }
        public DateTime? FechaExpiracion { get; set; }

        public ICollection<Clientes> Clientes { get; set; }
    }
}
