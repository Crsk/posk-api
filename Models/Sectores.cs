using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Sectores
    {
        public Sectores()
        {
            CategoriaSector = new HashSet<CategoriaSector>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public sbyte Seleccionable { get; set; }

        public ICollection<CategoriaSector> CategoriaSector { get; set; }
    }
}
