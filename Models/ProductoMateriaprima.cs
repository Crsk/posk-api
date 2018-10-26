using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class ProductoMateriaprima
    {
        public int Id { get; set; }
        public int? MateriaprimaId { get; set; }
        public int? ProductoId { get; set; }
        public decimal? Cantidad { get; set; }

        public Materiasprimas Materiaprima { get; set; }
        public Productos Producto { get; set; }
    }
}
