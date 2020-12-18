using MattsRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartRepository ShoppingCart { get; set; }
        public double ShoppingCartTotal { get; set; }
    }
}
