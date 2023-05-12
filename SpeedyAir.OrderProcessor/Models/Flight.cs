using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyAir.OrderProcessor.Models
{
    internal class Flight
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int Day { get; set; }
        public int Capacity { get; set; }
    }
}
