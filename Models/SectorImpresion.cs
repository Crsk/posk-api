using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class SectorImpresion
    {
        public SectorImpresion()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Impresora { get; set; }

        public ICollection<Productos> Productos { get; set; }
    }
}
