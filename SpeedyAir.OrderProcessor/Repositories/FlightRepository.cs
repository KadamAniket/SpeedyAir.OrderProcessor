using SpeedyAir.OrderProcessor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyAir.OrderProcessor.Repositories
{
    internal class FlightRepository
    {
        public List<Flight> GetAllFlights()
        {
            List<Flight> Flights = new List<Flight>();
            Flights.Add(new Flight() { Id = 1, Source = "YUL", Destination = "YYZ",Capacity=20,ServiceType= ServiceType.SAME_DAY });
            Flights.Add(new Flight() { Id = 2, Source = "YUL", Destination = "YYC",Capacity=20,ServiceType= ServiceType.SAME_DAY });
            Flights.Add(new Flight() { Id = 3, Source = "YUL", Destination = "YVR",Capacity=20,ServiceType= ServiceType.SAME_DAY });
            Flights.Add(new Flight() { Id = 4, Source = "YUL", Destination = "YYZ", Capacity = 20, ServiceType = ServiceType.NEXT_DAY });
            Flights.Add(new Flight() { Id = 5, Source = "YUL", Destination = "YYC", Capacity = 20, ServiceType = ServiceType.NEXT_DAY });
            Flights.Add(new Flight() { Id = 6, Source = "YUL", Destination = "YVR", Capacity = 20, ServiceType = ServiceType.NEXT_DAY });
            Flights.Add(new Flight() { Id = 7, Source = "YUL", Destination = "YYC", Capacity = 20, ServiceType = ServiceType.REGULAR });
            Flights.Add(new Flight() { Id = 8, Source = "YUL", Destination = "YVR", Capacity = 20, ServiceType = ServiceType.REGULAR });
            return Flights;
        }

    }
}
