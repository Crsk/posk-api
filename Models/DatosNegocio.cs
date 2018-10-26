using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class DatosNegocio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
        public string Direccion { get; set; }
        public string Logo { get; set; }
        public int? Iva { get; set; }
        public string InicioJornadaDia { get; set; }
        public string TerminoJornadaDia { get; set; }
        public TimeSpan? InicioJornadaHora { get; set; }
        public TimeSpan? TerminoJornadaHora { get; set; }
        public string Modo { get; set; }
        public string CorreoPrimario { get; set; }
        public string CorreoSecundario { get; set; }
        public sbyte? TecladoTactilIntegrado { get; set; }
        public sbyte PagoInmediato { get; set; }
    }
}
