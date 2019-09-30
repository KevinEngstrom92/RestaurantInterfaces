using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RestaurantInterfaces.Domain
{
    class CookMaster5000 : ICook
    {

        public void Cook(Order order)
        {
            Console.Clear();
            order.Started();
            Thread.Sleep(1000);
            order.Completed();
        }
    }
}
