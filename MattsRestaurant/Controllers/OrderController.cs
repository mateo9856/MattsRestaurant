using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattsRestaurant.Models;
using MattsRestaurant.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MattsRestaurant.Controllers
{
    
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCartRepository _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCartRepository shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(Order order)
        {
            var items = _shoppingCart.GetItems();
            _shoppingCart.items = items;

            if(_shoppingCart.items.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckOutCompleteMessage = "Thanks for you order!";
            OrderViewModel model = new OrderViewModel()
            {
                orderDetail = _orderRepository.GetOrderDetails(),
            };
            return View(model);
        }

    }
}
