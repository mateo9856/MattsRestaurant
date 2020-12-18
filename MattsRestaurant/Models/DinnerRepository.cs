using System.Collections.Generic;
using System.Linq;

namespace MattsRestaurant.Models
{
    public class DinnerRepository : IDinnerRepository
    {
        public IEnumerable<Dinner> dinners =>
            new List<Dinner>
            {
                new Dinner
                {
                    DinnerId = 0,
                    Name = "Pierogi Ruskie",
                    Description = "Kurwa nie pierdol wpierdalaj pierogi!!",
                    Allergens = "Gluten",
                    DinnerOfTheDay = true,
                    ImageUrl = "",
                    DinnerCategory = "Dania z ciasta",
                    Price = 6.50,
                    CuisineType = Cuisine.Polish

    }
};

        public IEnumerable<Dinner> GetAllDinners()
        {
            return from d in dinners
                   select d;
        }

        public IEnumerable<Dinner> DinnerOdTheDay()
        {
            return from d in dinners
                   where d.DinnerOfTheDay == true
                   select d;
        }

        public Dinner GetById(int dinnerId)
        {
            return dinners.FirstOrDefault(d => d.DinnerId == dinnerId);
        }


    }
}