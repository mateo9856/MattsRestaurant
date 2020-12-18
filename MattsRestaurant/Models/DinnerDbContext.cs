
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class DinnerDbContext : DbContext 
    { 
        public DinnerDbContext(DbContextOptions<DinnerDbContext> options) : base(options)
        {

        }
        public DbSet<Dinner> dinners { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Dinner>().HasData(new Dinner//model builder budulec wartosci
            {
                DinnerId = 1,
                Name = "Pizza Capriciosa",
                Description = "Type of pizza with ham, mushroom and tomatos",
                Allergens = "Gluten, Eggs, Lactose, Soybeans",
                DinnerOfTheDay = false,
                ImageUrl = "~/images/PizzaCapriciosa.png",
                DinnerCategory = "FastFood",
                Price = 19.20,
                CuisineType = Cuisine.Italian
            });
            modelBuilder.Entity<Dinner>().HasData(new Dinner
            {
                DinnerId = 2,
                Name = "Skewers",
                Description = "A long piece of wood or metal used for holding pieces of food, typically meat, together during cooking",
                Allergens = "Gluten, Lactose",
                DinnerOfTheDay = false,
                ImageUrl = "~/images/Skewers.png",
                DinnerCategory = "Barbeque foods",
                Price = 10.00,
                CuisineType = Cuisine.Indian
            });
            modelBuilder.Entity<Dinner>().HasData(new Dinner
            {
                DinnerId = 3,
                Name = "Dumplings",
                Description = "Sticky dough with stuffing inside.\nTypes: Russia, With meat, sweets, with blueberries, with spinach",
                Allergens = "Gluten, Lactose, Soyabeans, Eggs",
                DinnerOfTheDay = true,
                ImageUrl = "~/images/Dumplings.png",
                DinnerCategory = "Cake Dinner",
                Price = 9.00,
                CuisineType = Cuisine.Polish
            });
            modelBuilder.Entity<Dinner>().HasData(new Dinner
            {
                DinnerId = 4,
                Name = "Japanesse Sushi",
                Description = "A Japanese dish consisting of small balls or rolls of vinegar-flavoured cold rice served with a garnish of vegetables, egg, or raw seafood.",
                Allergens = "Eggs, Milk, Celary, Mustard",
                DinnerOfTheDay = false,
                ImageUrl = "~/images/Sushi.png",
                DinnerCategory = "Japanesse Kitchen",
                Price = 18.00,
                CuisineType = Cuisine.Asian
            });
            modelBuilder.Entity<Dinner>().HasData(new Dinner
            {
                DinnerId = 5,
                Name = "Lasagne Bolognesse",
                Description = "An Italian dish consisting of lasagne baked with meat or vegetables and a cheese sauce.",
                Allergens = "Gluten, Milk, Lactose, Eggs",
                DinnerOfTheDay = false,
                ImageUrl = "~/images/Lasagne.png",
                DinnerCategory = "Baked Dishes",
                Price = 12.00,
                CuisineType = Cuisine.Italian
            });
            modelBuilder.Entity<Dinner>().HasData(new Dinner
            { 
                DinnerId = 6,
                Name = "De voliaille",
                Description = "Chicken breasts stuffed with cheese, butter and spinnach",
                Allergens = "Gluten, Eggs, Lactose",
                DinnerOfTheDay = false,
                ImageUrl = "~/images/De volaille.png",
                DinnerCategory = "Main Dishes",
                Price = 18.00,
                CuisineType = Cuisine.Polish
            });
            modelBuilder.Entity<Dinner>().HasData(new Dinner
            { 
                DinnerId = 7,
                Name = "Basil Pesto",
                Description = "Pesto has become a catch all word used to describe many different things today. It originated in Italy as a mortar-and-pestle ground, coarse sauce made of basil, pine nuts, garlic, Parmesan, and olive oil. ",
                Allergens = "Gluten, Eggs, Lactose",
                DinnerOfTheDay = false,
                ImageUrl = "~/images/Basil Pesto.png",
                DinnerCategory = "Italian Food",
                Price = 22.00,
                CuisineType = Cuisine.Italian,
            });
            
            modelBuilder.Entity<ShoppingCart>().HasKey(c => c.cartItemId);
            modelBuilder.Entity<Order>().HasKey(c => c.OrderId);
            modelBuilder.Entity<OrderDetail>().HasKey(c => c.OrderDetailId);
         }
    }
}
