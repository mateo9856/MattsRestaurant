using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattsRestaurant.Models;
using MattsRestaurant.ViewModels;
using Microsoft.AspNetCore.Mvc;



namespace MattsRestaurant.Controllers
{
    public class DinnerController : Controller
    {
        private readonly IDinnerRepository _dinnerRepository;
        public DinnerController(IDinnerRepository dinnerRepository)
        {
            _dinnerRepository = dinnerRepository;
        }

        public string Welcome()
        {
            return "Hello, MAN";
        }
        public ViewResult ListDinners()
        {
            ListDinnerViewModel model = new ListDinnerViewModel();
            model.dinners = _dinnerRepository.dinners;
            model.Category = "Dinners";
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var dinner = _dinnerRepository.GetById(id);
            if(dinner == null)
            {
                return NotFound();
            }
            return View(dinner);
        }
    }
}
