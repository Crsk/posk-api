using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class PedidosAgregados
    {
        public int Id { get; set; }
        public int? PedidosProductosId { get; set; }
        public int? AgregadoUnoId { get; set; }
        public int? AgregadoDosId { get; set; }

        public Agregados AgregadoDos { get; set; }
        public Agregados AgregadoUno { get; set; }
        public PedidosProductos PedidosProductos { get; set; }
    }
}
