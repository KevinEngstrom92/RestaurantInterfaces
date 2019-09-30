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

        public void Started()
        {
            if(StartedAt == null)
            {
                StartedAt = DateTime.Now;
            }
            else
            {
                throw new Exception("Order Already Started");
            }

        }
        public void Completed()
        {
            if(StartedAt != null && CompletedAt == null)
            {
                CompletedAt = DateTime.Now;
            }
            else
            {
                throw new Exception("Either the order is not started or its already completed");
            }
        }
        public DateTime? StartedAt { get; private set; }
        public DateTime? CompletedAt { get; set; }

        public Order(string dish, string table)
        {
            this.Dish = dish;
            this.Table = table;
        }
        

       
    }
}
