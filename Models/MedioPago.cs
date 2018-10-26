using System;
using System.Collections.Generic;

namespace PoskApi.Models
{
    public partial class MedioPago
    {
        public MedioPago()
        {
            BoletaMediopago = new HashSet<BoletaMediopago>();
            DeliveryItem = new HashSet<DeliveryItem>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<BoletaMediopago> BoletaMediopago { get; set; }
        public ICollection<DeliveryItem> DeliveryItem { get; set; }
    }
}
