using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Pendientes
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public sbyte? Archivado { get; set; }
        public int? PromocionId { get; set; }

        public Productos Producto { get; set; }
        public Promociones Promocion { get; set; }
        public Usuarios Usuario { get; set; }
    }
}
