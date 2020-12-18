using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class ShoppingCart
    {
        public int cartItemId { get; set; }
        public Dinner dinner { get; set; }
        public int Amount { get; set; }
        public string cartId { get; set; }
    }
}
