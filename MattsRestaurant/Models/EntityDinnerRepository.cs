using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class EntityDinnerRepository : IDinnerRepository
    {
        private readonly DinnerDbContext _dinnerDbContext;

        public EntityDinnerRepository(DinnerDbContext dinnerDbContext)
        {
            _dinnerDbContext = dinnerDbContext;
        }

        public IEnumerable<Dinner> dinners => _dinnerDbContext.dinners;

        public IEnumerable<Dinner> DinnerOdTheDay()
        {
            return _dinnerDbContext.dinners.Where(c => c.DinnerOfTheDay == true);
        }

        public IEnumerable<Dinner> GetAllDinners()
        {
            return _dinnerDbContext.dinners;
            
        }

        public Dinner GetById(int dinnerId)
        {
            return _dinnerDbContext.dinners.FirstOrDefault(d => d.DinnerId == dinnerId);
        }
    }
}
