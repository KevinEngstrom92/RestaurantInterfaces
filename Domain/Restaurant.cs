using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantInterfaces.Domain
{
    class Restaurant
    {
        public string Name { get; set; }
        private Queue<Order> OrderQueue { get; } = new Queue<Order>();


        public Restaurant(string name)
        {
            this.Name = name;
        }

        internal void RegisterOrder(Order order)
        {
            OrderQueue.Enqueue(order);
        }
    }
}
