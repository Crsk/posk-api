using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Categorias
    {
        public Categorias()
        {
            CategoriaSector = new HashSet<CategoriaSector>();
            CategoriaSubcategoria = new HashSet<CategoriaSubcategoria>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public sbyte? Seleccionable { get; set; }

        public ICollection<CategoriaSector> CategoriaSector { get; set; }
        public ICollection<CategoriaSubcategoria> CategoriaSubcategoria { get; set; }
    }
}
