using System;
using System.Collections.Generic;
using AdapterClima.Interfaces;

namespace AdapterClima.Models
{
    public class Cities
    {
        public string name { get; set; } = string.Empty;
        public double latitude { get; set; } = 0.0;
        public double longitude { get; set; } = 0.0;
        public double temperature { get; set; } = 0.0;
    }
}