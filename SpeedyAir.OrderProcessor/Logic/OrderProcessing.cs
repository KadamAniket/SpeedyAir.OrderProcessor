using SpeedyAir.OrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SpeedyAir.OrderProcessor.Logic
{
    internal class OrderProcessing : IOrderProcess
    {
        public void ProcessOrders(IList<Order> orders, IList<Flight> flights)
        {
            var sortedFlights = flights.OrderBy(m => m.ServiceType);

            foreach (var order in orders)
            {
                foreach (var flight in sortedFlights)
                {
                    if (order.Destination == flight.Destination && order.ServiceType == flight.ServiceType && flight.Capacity > 0)
                    {
                        order.FlightId = flight.Id;
                        flight.Capacity--;
                        break;
                    }
                }
            }
        }
    }
}
