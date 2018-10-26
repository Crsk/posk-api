using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Mesas
    {
        public Mesas()
        {
            Pedidos = new HashSet<Pedidos>();
            Reservas = new HashSet<Reservas>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public sbyte? Libre { get; set; }
        public int? SectorId { get; set; }
        public int? UsuarioId { get; set; }
        public int? Items { get; set; }

        public Sectormesas Sector { get; set; }
        public Usuarios Usuario { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
        public ICollection<Reservas> Reservas { get; set; }
    }
}
