using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Direcciones
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? ClienteId { get; set; }

        public Clientes Cliente { get; set; }
    }
}
