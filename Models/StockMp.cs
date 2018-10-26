using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class StockMp
    {
        public int Id { get; set; }
        public int? MateriaprimaId { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
        public decimal Ajuste { get; set; }

        public Materiasprimas Materiaprima { get; set; }
    }
}
