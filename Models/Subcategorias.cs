using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Subcategorias
    {
        public Subcategorias()
        {
            CategoriaSubcategoria = new HashSet<CategoriaSubcategoria>();
            Productos = new HashSet<Productos>();
            Promociones = new HashSet<Promociones>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<CategoriaSubcategoria> CategoriaSubcategoria { get; set; }
        public ICollection<Productos> Productos { get; set; }
        public ICollection<Promociones> Promociones { get; set; }
    }
}
