using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class BodegaMovimiento
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public DateTime? Fecha { get; set; }
        public int? JornadaId { get; set; }
        public decimal? Entrada { get; set; }
        public decimal? Salida { get; set; }

        public Jornadas Jornada { get; set; }
        public Productos Producto { get; set; }
    }
}
