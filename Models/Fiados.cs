using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Fiados
    {
        public Fiados()
        {
            LineasFiado = new HashSet<LineasFiado>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Total { get; set; }
        public int? ClienteId { get; set; }
        public int? UsuarioId { get; set; }

        public Clientes Cliente { get; set; }
        public Usuarios Usuario { get; set; }
        public ICollection<LineasFiado> LineasFiado { get; set; }
    }
}
