using Microsoft.EntityFrameworkCore;
using System;
using MattsRestaurant.Models;
namespace MattsRestaurant.Database
{
    public class DinnerDbContext : DbContext
    {
        public DinnerDbContext(DbContextOptions<DinnerDbContext> options) : base(options)
        {

        }
        public DbSet<Dinner> dinners { get; set; }
    }
}
