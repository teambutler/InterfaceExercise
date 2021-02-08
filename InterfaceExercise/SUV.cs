using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public SUV()
        {
        }
        public bool isFourWheelDrive { get; set; } = true;
        public bool isFourDoor { get; set; } = true;
        public string Logo { get; set; } = "Star";
        public string CompanyName { get; set; } = "McDougal";
        public string Make { get; set; } = "Nissan";
        public string Model { get; set; } = "Pathfinder";
        public string engineSize { get ; set ; } = "6 valve";
        public int SeatCount { get; set; } = 6;
      
    }
}
