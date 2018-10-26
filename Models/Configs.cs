using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Configs
    {
        public Configs()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }
        public string FontSize { get; set; }
        public string Theme { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
