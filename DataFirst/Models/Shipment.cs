using System;
using System.Collections.Generic;

#nullable disable

namespace DataFirst.Models
{
    public partial class Shipment
    {
        public int Id { get; set; }
        public DateTime? DateOfDelivery { get; set; }
        public string LocationOfDelivery { get; set; }
        public int? CustomerIdInt { get; set; }
        public int? ProductIdInt { get; set; }
    }
}
