﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyAir.OrderProcessor.Models
{
    internal class Order
    {
        public string Id { get; set; }
        public string Destination { get; set; }
        public int FlightId { get; set; }

    }
}
