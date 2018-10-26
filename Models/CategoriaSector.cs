using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class CategoriaSector
    {
        public int Id { get; set; }
        public int? CategoriaId { get; set; }
        public int? SectorId { get; set; }

        public Categorias Categoria { get; set; }
        public Sectores Sector { get; set; }
    }
}
