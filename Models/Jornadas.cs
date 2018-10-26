using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Jornadas
    {
        public Jornadas()
        {
            BodegaMovimiento = new HashSet<BodegaMovimiento>();
            CantidadesvendidasJornada = new HashSet<CantidadesvendidasJornada>();
            VentasJornada = new HashSet<VentasJornada>();
        }

        public int Id { get; set; }
        public DateTime? FechaApertura { get; set; }
        public DateTime? FechaCierre { get; set; }
        public sbyte? Especial { get; set; }
        public string Mensaje { get; set; }
        public int? Ingresos { get; set; }
        public int? UsuarioId { get; set; }
        public int CajaInicialEfectivo { get; set; }

        public Usuarios Usuario { get; set; }
        public ICollection<BodegaMovimiento> BodegaMovimiento { get; set; }
        public ICollection<CantidadesvendidasJornada> CantidadesvendidasJornada { get; set; }
        public ICollection<VentasJornada> VentasJornada { get; set; }
    }
}
