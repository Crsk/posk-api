using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class BoletaMediopago
    {
        public int Id { get; set; }
        public int? BoletaId { get; set; }
        public int? MediopagoId { get; set; }
        public int Ingreso { get; set; }
        public int? VendedorId { get; set; }

        public Boletas Boleta { get; set; }
        public MedioPago Mediopago { get; set; }
        public Usuarios Vendedor { get; set; }
    }
}
