namespace SpeedyAir.OrderProcessor.Models
{
    internal class Order
    {
        public string Id { get; set; }
        public string Destination { get; set; }
        public ServiceType ServiceType { get; set; }
        public int FlightId { get; set; }

    }
}
