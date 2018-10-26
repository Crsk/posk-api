using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Registros
    {
        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? UsuarioId { get; set; }
        public string Tipo { get; set; }
        public string Detalle { get; set; }

        public Usuarios Usuario { get; set; }
    }
}
