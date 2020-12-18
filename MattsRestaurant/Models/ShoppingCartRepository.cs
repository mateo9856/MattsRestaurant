using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class ShoppingCartRepository
    {
        private readonly DinnerDbContext _dbContext;

        public string ShoppingCartId { get; set; }
        public List<ShoppingCart> items { get; set; }

        public ShoppingCartRepository(DinnerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public static ShoppingCartRepository GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<DinnerDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCartRepository(context)
            {
                ShoppingCartId = cartId
            };
        }

        public void AddToCart(Dinner dinner, int amount)
        {
            var shoppingCartItem = _dbContext.shoppingCarts.SingleOrDefault(s => s.dinner.DinnerId == dinner.DinnerId && s.cartId == ShoppingCartId);
        
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCart
                {
                    cartId = ShoppingCartId,
                    dinner = dinner,
                    Amount = 1
                };
                _dbContext.shoppingCarts.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _dbContext.SaveChanges();
        }
        public int RemoveFromCart(Dinner dinner)
        {
            var shoppingCartItem = _dbContext.shoppingCarts.SingleOrDefault(s => s.dinner.DinnerId == dinner.DinnerId && s.cartId == ShoppingCartId);
            var localAmount = 0;
            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _dbContext.shoppingCarts.Remove(shoppingCartItem);
                }
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _dbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCart> GetItems()
        {
            return items ??
                (items = _dbContext.shoppingCarts.Where(c => c.cartId == ShoppingCartId)
                .Include(s => s.dinner).ToList());
        }

        public void ClearCart()
        {
            var cartItems = _dbContext.shoppingCarts.Where(c => c.cartId == ShoppingCartId);

            _dbContext.shoppingCarts.RemoveRange(cartItems);

            _dbContext.SaveChanges();
        }

        public double GetTotal()
        {
            var total = _dbContext.shoppingCarts.Where(c => c.cartId == ShoppingCartId)
                .Select(c => c.dinner.Price * c.Amount).Sum();
            return total;
        }

    }
}
