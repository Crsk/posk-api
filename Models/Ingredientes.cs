using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Ingredientes
    {
        public Ingredientes()
        {
            OpcionalesIngredientes = new HashSet<OpcionalesIngredientes>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }

        public ICollection<OpcionalesIngredientes> OpcionalesIngredientes { get; set; }
    }
}
