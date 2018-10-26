using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Sectormesas
    {
        public Sectormesas()
        {
            Mesas = new HashSet<Mesas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Mesas> Mesas { get; set; }
    }
}
