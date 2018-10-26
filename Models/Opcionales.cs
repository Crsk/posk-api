using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Opcionales
    {
        public Opcionales()
        {
            OpcionalesIngredientes = new HashSet<OpcionalesIngredientes>();
            TipoProductoOpcionales = new HashSet<TipoProductoOpcionales>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public ICollection<OpcionalesIngredientes> OpcionalesIngredientes { get; set; }
        public ICollection<TipoProductoOpcionales> TipoProductoOpcionales { get; set; }
    }
}
