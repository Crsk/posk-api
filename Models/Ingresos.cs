using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Ingresos
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaDesde { get; set; }
        public DateTime? FechaHasta { get; set; }
        public int? UsuarioId { get; set; }
        public int CajaInicialEfectivo { get; set; }

        public Usuarios Usuario { get; set; }
    }
}
