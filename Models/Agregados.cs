using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class Agregados
    {
        public Agregados()
        {
            PedidosAgregadosAgregadoDos = new HashSet<PedidosAgregados>();
            PedidosAgregadosAgregadoUno = new HashSet<PedidosAgregados>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? CobroExtra { get; set; }
        public int FontSize { get; set; }
        public sbyte? ParaHandroll { get; set; }
        public sbyte EsVegetal { get; set; }

        public ICollection<PedidosAgregados> PedidosAgregadosAgregadoDos { get; set; }
        public ICollection<PedidosAgregados> PedidosAgregadosAgregadoUno { get; set; }
    }
}
