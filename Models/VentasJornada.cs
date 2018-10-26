using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class VentasJornada
    {
        public int Id { get; set; }
        public int? JornadaId { get; set; }
        public int? Cantidad { get; set; }
        public int CobroExtra { get; set; }
        public int DetalleBoletaId { get; set; }
        public string Opcion { get; set; }
        public DateTime Fecha { get; set; }

        public DetalleBoleta DetalleBoleta { get; set; }
        public Jornadas Jornada { get; set; }
    }
}
