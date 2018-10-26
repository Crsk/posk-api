using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class OpcionalesIngredientes
    {
        public int Id { get; set; }
        public int OpcionalId { get; set; }
        public int IngredienteId { get; set; }

        public Ingredientes Ingrediente { get; set; }
        public Opcionales Opcional { get; set; }
    }
}
