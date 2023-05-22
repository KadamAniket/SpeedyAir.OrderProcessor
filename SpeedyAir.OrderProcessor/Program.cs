using System;
using System.Collections.Generic;
using System.Linq;
using SpeedyAir.OrderProcessor.Logic;
using SpeedyAir.OrderProcessor.Models;
using SpeedyAir.OrderProcessor.Repositories;

namespace SpeedyAir.OrderProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Flight Details");
            Console.WriteLine("2. Order Details");
            Console.WriteLine("Enter your Choice");
            int userSelection = Convert.ToInt32(Console.ReadLine());
            switch (userSelection)
            {
                case 1:
                    DisplayFlightDetails();
                    break;

                case 2:
                    DisplayBookedOrderDetails();
                    break;
            }

            Console.ReadLine();
        }

        private static void DisplayFlightDetails()
        {
            var flightRepository = new FlightRepository();
            var flights = flightRepository.GetAllFlights();
            foreach (var flight in flights)
            {
                Console.WriteLine("Flight:{0},Departure:{1},Arrival:{2},Day:{3}", flight.Id, flight.Source, flight.Destination, flight.ServiceType);
            }
        }

        private static void DisplayBookedOrderDetails()
        {
            var orderRepository = new OrderRepository();
            var orders = orderRepository.GetAllOrders();
            var flightRepository = new FlightRepository();
            var flights = flightRepository.GetAllFlights();

            var orderProcessing = new OrderProcessing();
            orderProcessing.ProcessOrders(orders, flights);

            foreach (var order in orders)
            {
                var flightInfo = flights.FirstOrDefault(f => f.Id == order.FlightId);

                if (flightInfo != null)
                {
                    Console.WriteLine("Order:{0},FlightNumber:{1},Departure:{2}, Arrival:{3}, Day:{4}", order.Id,
                    order.FlightId, flightInfo.Source, flightInfo.Destination, flightInfo.ServiceType);
                }
                else
                {
                    Console.WriteLine("Order:{0},FlightNumber: NotScheduled", order.Id);
                }

            }
        }
    }
}
