using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Materiasprimas
    {
        public Materiasprimas()
        {
            ProductoMateriaprima = new HashSet<ProductoMateriaprima>();
            StockMp = new HashSet<StockMp>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? UnidadMedidaId { get; set; }

        public UnidadesMedida UnidadMedida { get; set; }
        public ICollection<ProductoMateriaprima> ProductoMateriaprima { get; set; }
        public ICollection<StockMp> StockMp { get; set; }
    }
}
