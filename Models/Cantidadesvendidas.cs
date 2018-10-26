using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Cantidadesvendidas
    {
        public Cantidadesvendidas()
        {
            CantidadesvendidasJornada = new HashSet<CantidadesvendidasJornada>();
        }

        public int Id { get; set; }
        public string Itemventa { get; set; }
        public decimal Cantidad { get; set; }

        public ICollection<CantidadesvendidasJornada> CantidadesvendidasJornada { get; set; }
    }
}
