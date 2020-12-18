using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public int DinnerId { get; set; }
        public virtual Dinner Dinner { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
