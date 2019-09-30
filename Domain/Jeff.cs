using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RestaurantInterfaces.Domain
{
    class Jeff : ICook
    {
        public string Name { get; } = "Jeff";

       public void Cook(Order order)
        {
            Console.Clear();
            order.Started();
            Thread.Sleep(5000);
            order.Completed();

        }
}
}
