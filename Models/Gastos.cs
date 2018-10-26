using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Gastos
    {
        public int Id { get; set; }
        public string Detalle { get; set; }
        public decimal? Monto { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
