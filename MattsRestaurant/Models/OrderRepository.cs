using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattsRestaurant.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DinnerDbContext _dbContext;
        private readonly ShoppingCartRepository _shoppingCart;
        public OrderRepository(DinnerDbContext dbContext, ShoppingCartRepository shoppingCart)
        {
            _dbContext = dbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {

            order.timeToPlaced = DateTime.Now;
            _dbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.items;

            _dbContext.SaveChanges();

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = item.Amount,
                    DinnerId = item.dinner.DinnerId,
                    OrderId = order.OrderId,
                    Price = item.dinner.Price
                };
                _dbContext.OrderDetails.Add(orderDetail);
            }
            _dbContext.SaveChanges();
        }

        public OrderDetail GetOrderDetails()
        {
            return _dbContext.OrderDetails.OrderByDescending(d => d.OrderDetailId).FirstOrDefault();
        }

    }
}