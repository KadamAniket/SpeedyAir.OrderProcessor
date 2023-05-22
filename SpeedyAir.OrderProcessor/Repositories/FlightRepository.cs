using SpeedyAir.OrderProcessor.Models;
using System.Collections.Generic;

namespace SpeedyAir.OrderProcessor.Repositories
{
    internal class FlightRepository : IRepository<Flight>
    {
        public IList<Flight> GetAll()
        {
            List<Flight> flights = new List<Flight>();

            flights.Add(new Flight() { Id = 1, Source = "YUL", Destination = "YYZ",Capacity=20,ServiceType= ServiceType.SAME_DAY });
            flights.Add(new Flight() { Id = 2, Source = "YUL", Destination = "YYC",Capacity=20,ServiceType= ServiceType.SAME_DAY });
            flights.Add(new Flight() { Id = 3, Source = "YUL", Destination = "YVR",Capacity=20,ServiceType= ServiceType.SAME_DAY });
            flights.Add(new Flight() { Id = 4, Source = "YUL", Destination = "YYZ", Capacity = 20, ServiceType = ServiceType.NEXT_DAY });
            flights.Add(new Flight() { Id = 5, Source = "YUL", Destination = "YYC", Capacity = 20, ServiceType = ServiceType.NEXT_DAY });
            flights.Add(new Flight() { Id = 6, Source = "YUL", Destination = "YVR", Capacity = 20, ServiceType = ServiceType.NEXT_DAY });
            flights.Add(new Flight() { Id = 7, Source = "YUL", Destination = "YYC", Capacity = 20, ServiceType = ServiceType.REGULAR });
            flights.Add(new Flight() { Id = 8, Source = "YUL", Destination = "YVR", Capacity = 20, ServiceType = ServiceType.REGULAR });
            
            return flights;
        }

    }
}
