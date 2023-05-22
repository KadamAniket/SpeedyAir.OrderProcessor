using SpeedyAir.OrderProcessor.Factory;
using SpeedyAir.OrderProcessor.Logic;
using SpeedyAir.OrderProcessor.Models;
using SpeedyAir.OrderProcessor.Repositories;
using System;
using System.Linq;

namespace SpeedyAir.OrderProcessor
{
    internal class Program
    {
        private static IRepository<Flight> flightRepository;
        private static IRepository<Order> orderRepository;
        private static IOrderProcess orderProcess;

        static void Main(string[] args)
        {
            int userSelection;
            var di = new DIFactory();

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------");
                Console.WriteLine("1. Flight Details");
                Console.WriteLine("2. Order Details");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your Choice");
                userSelection = Convert.ToInt32(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        flightRepository = di.GetFlightRepository();
                        DisplayFlightDetails();
                        break;

                    case 2:
                        flightRepository = di.GetFlightRepository();
                        orderRepository = di.GetOrderRepository();
                        orderProcess = di.GetOrderProcessor();
                        DisplayBookedOrderDetails();
                        break;
                }

                
                Console.ReadLine();

            } while (userSelection != 3);
        }

        private static void DisplayFlightDetails()
        {
            var flights = flightRepository.GetAll();
            foreach (var flight in flights)
            {
                Console.WriteLine("Flight:{0},Departure:{1},Arrival:{2},Day:{3}", flight.Id, flight.Source, flight.Destination, flight.ServiceType);
            }
        }

        private static void DisplayBookedOrderDetails()
        {
            var orders = orderRepository.GetAll();
            var flights = flightRepository.GetAll();

            orderProcess.ProcessOrders(orders, flights);

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
