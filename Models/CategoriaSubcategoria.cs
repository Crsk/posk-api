using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class CategoriaSubcategoria
    {
        public int Id { get; set; }
        public int? CategoriaId { get; set; }
        public int? SubcategoriaId { get; set; }

        public Categorias Categoria { get; set; }
        public Subcategorias Subcategoria { get; set; }
    }
}
