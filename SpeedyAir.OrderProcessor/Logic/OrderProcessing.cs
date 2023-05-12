using SpeedyAir.OrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace SpeedyAir.OrderProcessor.Logic
{
    internal class OrderProcessing
    {
        public void ProcessOrders(List<Order> orders, List<Flight> flights)
        {
            var sortedFlights = flights.OrderBy(m => m.Day).ToList();

            foreach (var order in orders)
            {
                foreach (var flight in sortedFlights)
                {
                    if (order.Destination == flight.Destination && flight.Capacity > 0)
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
