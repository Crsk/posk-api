using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class StockPr
    {
        public int Id { get; set; }
        public int? ProductoId { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
        public decimal Ajuste { get; set; }

        public Productos Producto { get; set; }
    }
}
