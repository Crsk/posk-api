using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Mermas
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public DateTime? Fecha { get; set; }

        public Productos Producto { get; set; }
    }
}
