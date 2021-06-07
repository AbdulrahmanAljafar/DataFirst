using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataFirst.Models
{
    public class Join
    {
        public DateTime? DateOfDelivery { get; set; }
        public string LocationOfDelivery { get; set; }
        public string customer_name { get; set; }
        public string product_name { get; set; }
    }
}
