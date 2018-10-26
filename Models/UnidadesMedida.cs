using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class UnidadesMedida
    {
        public UnidadesMedida()
        {
            Materiasprimas = new HashSet<Materiasprimas>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Materiasprimas> Materiasprimas { get; set; }
    }
}
