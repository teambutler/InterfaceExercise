using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string engineSize { get; set; }
        public int SeatCount { get; set; }

    }
}
