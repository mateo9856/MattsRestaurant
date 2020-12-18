using MattsRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.ViewModels
{
    public class ListDinnerViewModel
    {
        public IEnumerable<Dinner> dinners { get; set; }
        public string Category { get; set; }
    }
}
