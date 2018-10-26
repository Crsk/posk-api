using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Boletas = new HashSet<Boletas>();
            DeliveryItem = new HashSet<DeliveryItem>();
            Deudas = new HashSet<Deudas>();
            Direcciones = new HashSet<Direcciones>();
            Fiados = new HashSet<Fiados>();
            PrestamoEnvases = new HashSet<PrestamoEnvases>();
        }

        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Pass { get; set; }
        public string Contacto { get; set; }
        public sbyte? Favorito { get; set; }
        public int PuntosId { get; set; }
        public string Comentario { get; set; }
        public string Imagen { get; set; }
        public string Telefono { get; set; }

        public Puntos Puntos { get; set; }
        public ICollection<Boletas> Boletas { get; set; }
        public ICollection<DeliveryItem> DeliveryItem { get; set; }
        public ICollection<Deudas> Deudas { get; set; }
        public ICollection<Direcciones> Direcciones { get; set; }
        public ICollection<Fiados> Fiados { get; set; }
        public ICollection<PrestamoEnvases> PrestamoEnvases { get; set; }
    }
}
