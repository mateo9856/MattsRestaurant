using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattsRestaurant.Models;
using MattsRestaurant.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MattsRestaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly IDinnerRepository _dinnerRepository;
        private readonly ShoppingCartRepository _shoppingCartRepository;

        public CartController(IDinnerRepository dinnerRepository, ShoppingCartRepository shoppingCartRepository)
        {
            _dinnerRepository = dinnerRepository;
            _shoppingCartRepository = shoppingCartRepository;
        }

        public ViewResult Index()
        {
            var items = _shoppingCartRepository.GetItems();
            _shoppingCartRepository.items = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCartRepository,
                ShoppingCartTotal = _shoppingCartRepository.GetTotal()
            };
            return View(shoppingCartViewModel);
        }
        
        public RedirectToActionResult AddToCart(int dinnerId)
        {
            var dinner = _dinnerRepository.dinners.FirstOrDefault(d => d.DinnerId == dinnerId);
            if(dinner != null)
            {
                _shoppingCartRepository.AddToCart(dinner, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveCart(int dinnerId)
        {
            var dinner = _dinnerRepository.dinners.FirstOrDefault(d => d.DinnerId == dinnerId);
            if (dinner != null)
            {
                _shoppingCartRepository.RemoveFromCart(dinner);
            }
            return RedirectToAction("Index");
        }

    }    
}


