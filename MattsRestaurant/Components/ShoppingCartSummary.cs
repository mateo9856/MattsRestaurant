using MattsRestaurant.Models;
using MattsRestaurant.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MattsRestaurant.Components
{
    public class ShoppingCartSummary : ViewComponent //poczytac o view components
    {
        private readonly ShoppingCartRepository _shoppingCart;

        public ShoppingCartSummary(ShoppingCartRepository shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()//poczytac o metodach iaction result i innych bo co innego zwracaja
        {
            var items = _shoppingCart.GetItems();
            _shoppingCart.items = items;

            var shoppingCartView = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetTotal()
            };
            return View(shoppingCartView);
        }

    }
}
