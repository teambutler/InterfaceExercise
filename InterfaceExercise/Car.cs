using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
    class Car : ICompany, IVehicle
    {
        public string CompanyCar { get; set; }
        public bool isFourWheelDrive { get; set; } = false;
        public string Logo { get; set; } = "Triange";
        public string CompanyName { get; set; } = "McDougal Piping Company";
        public string Make { get; set; } = "Subaru";
        public string Model { get; set; } = "Forester";
        public string engineSize { get; set; } = "6.0 Liter";
        public int SeatCount { get; set; } = 5;
    }
}
