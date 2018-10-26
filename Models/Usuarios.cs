using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            BoletaMediopago = new HashSet<BoletaMediopago>();
            Boletas = new HashSet<Boletas>();
            Compras = new HashSet<Compras>();
            Fiados = new HashSet<Fiados>();
            Ingresos = new HashSet<Ingresos>();
            Jornadas = new HashSet<Jornadas>();
            Mesas = new HashSet<Mesas>();
            Pedidos = new HashSet<Pedidos>();
            Pendientes = new HashSet<Pendientes>();
            Registros = new HashSet<Registros>();
            Reservas = new HashSet<Reservas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public string Tipo { get; set; }
        public int ConfigId { get; set; }
        public string Imagen { get; set; }
        public sbyte? Favorito { get; set; }

        public Configs Config { get; set; }
        public ICollection<BoletaMediopago> BoletaMediopago { get; set; }
        public ICollection<Boletas> Boletas { get; set; }
        public ICollection<Compras> Compras { get; set; }
        public ICollection<Fiados> Fiados { get; set; }
        public ICollection<Ingresos> Ingresos { get; set; }
        public ICollection<Jornadas> Jornadas { get; set; }
        public ICollection<Mesas> Mesas { get; set; }
        public ICollection<Pedidos> Pedidos { get; set; }
        public ICollection<Pendientes> Pendientes { get; set; }
        public ICollection<Registros> Registros { get; set; }
        public ICollection<Reservas> Reservas { get; set; }
    }
}
