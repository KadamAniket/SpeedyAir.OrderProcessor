using SpeedyAir.OrderProcessor.Logic;
using SpeedyAir.OrderProcessor.Models;
using SpeedyAir.OrderProcessor.Repositories;

namespace SpeedyAir.OrderProcessor.Factory
{
    internal class DIFactory
    {
        private readonly IRepository<Flight> flightRepository;
        private readonly IRepository<Order> orderRepository;
        private readonly IOrderProcess orderProcess;

        public DIFactory()
        {
            flightRepository = new FlightRepository();
            orderRepository = new OrderRepository();
            orderProcess = new OrderProcessing();
        }

        public IRepository<Flight> GetFlightRepository()
        {
            return flightRepository;
        }

        public IRepository<Order> GetOrderRepository()
        {
            return orderRepository;
        }

        public IOrderProcess GetOrderProcessor()
        {
            return orderProcess;
        }
    }
}
