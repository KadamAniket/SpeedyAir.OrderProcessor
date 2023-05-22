using SpeedyAir.OrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyAir.OrderProcessor.Logic
{
    internal interface IOrderProcess
    {
        public void ProcessOrders(IList<Order> orders, IList<Flight> flights);
    }
}
