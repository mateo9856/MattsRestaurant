using MattsRestaurant.Models;
using System.Collections.Generic;

namespace MattsRestaurant.Models
{
    public interface IDinnerRepository
    {//do kazdej w modelu rozwinietej klasy mozna dac interfejs by rozwinely swoja funkcjonalnosc
        IEnumerable<Dinner> dinners { get; }
        IEnumerable<Dinner> GetAllDinners();
        IEnumerable<Dinner> DinnerOdTheDay();
        Dinner GetById(int dinnerId);
    }
}



