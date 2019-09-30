using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantInterfaces.Domain
{
    class Order
    {
        public string Dish { get; set;}
        public string Table { get; set; }
        public DateTime RegisteredAt { get; } = DateTime.Now;
        public DateTime? StartedAt { get; }
        public DateTime? CompletedAt { get; }

        public Order(string dish, string table)
        {
            this.Dish = dish;
            this.Table = table;
        }
        

       
    }
}
