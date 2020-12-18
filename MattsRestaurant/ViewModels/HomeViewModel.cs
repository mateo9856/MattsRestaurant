using MattsRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Dinner> dinnerOfTheDay { get; set; }
    }
}
