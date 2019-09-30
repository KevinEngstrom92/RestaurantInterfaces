using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RestaurantInterfaces.Domain
{
    class Restaurant
    {
        public List<Order> orderList = new List<Order>();
        public string Name { get; set; }
        public Queue<Order> OrderQueue { get; } = new Queue<Order>();
        private ICook chef = new Jeff();

        public Restaurant(string name)
        {
            this.Name = name;
        }
    
        internal void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }

        public List<Order> ProcessOrders()
        {
            while (OrderQueue.Any())
            {
                Order currentOrder = OrderQueue.Dequeue();

                chef.Cook(currentOrder);
                orderList.Add(currentOrder);
            }

            return orderList;
        }
    }
}
