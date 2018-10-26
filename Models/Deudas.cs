using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Deudas
    {
        public int Id { get; set; }
        public int? Cantidad { get; set; }
        public DateTime? Fecha { get; set; }
        public sbyte? Saldada { get; set; }
        public int? ProductoId { get; set; }
        public int? ClienteId { get; set; }
        public string Comentario { get; set; }

        public Clientes Cliente { get; set; }
        public Productos Producto { get; set; }
    }
}
