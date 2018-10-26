using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Envolturas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? CostoAdicional { get; set; }
        public int? ProductoId { get; set; }
        public sbyte? ParaHandroll { get; set; }
        public sbyte? ParaSuperhandroll { get; set; }

        public Productos Producto { get; set; }
    }
}
