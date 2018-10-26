using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Reservas
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? MesaId { get; set; }
        public int? UsuarioId { get; set; }

        public Mesas Mesa { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
