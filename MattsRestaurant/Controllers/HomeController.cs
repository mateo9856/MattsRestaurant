using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MattsRestaurant.Models;
using MattsRestaurant.ViewModels;

namespace MattsRestaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDinnerRepository _dinnerRepository;
        public HomeController(ILogger<HomeController> logger, IDinnerRepository dinnerRepository)
        {
            _logger = logger;
            _dinnerRepository = dinnerRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                dinnerOfTheDay = _dinnerRepository.DinnerOdTheDay()
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
