using System;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class Dinner
    {
        public int DinnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Allergens { get; set; }
        public bool DinnerOfTheDay { get; set; }
        public string ImageUrl { get; set; }
        public string DinnerCategory { get; set; }
        public double Price { get; set; }
        public Cuisine CuisineType { get; set; }
    }

}
