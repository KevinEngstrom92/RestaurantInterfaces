﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace RestaurantInterfaces.Domain
{
    interface ICook
    {
        void Cook(Order order); 
        
        
    }
}
