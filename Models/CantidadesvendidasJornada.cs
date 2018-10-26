using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class CantidadesvendidasJornada
    {
        public int Id { get; set; }
        public int? CantidadesvendidasId { get; set; }
        public int? JornadaId { get; set; }

        public Cantidadesvendidas Cantidadesvendidas { get; set; }
        public Jornadas Jornada { get; set; }
    }
}
