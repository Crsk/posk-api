using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class PrestamoEnvases
    {
        public int Id { get; set; }
        public int Envases { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }

        public Clientes Cliente { get; set; }
    }
}
