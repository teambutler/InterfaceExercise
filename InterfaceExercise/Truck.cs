using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public Truck()
        {

        }
        public int BedSize { get; set; }
        public bool isFourDoor { get; set; } = true;
        public string Logo { get; set; } = "Diamond";
        public string CompanyName { get; set; } = "Butler's Equipment";
        public string Make { get; set; } = "Dodge";
        public string Model { get; set; } = "Ram";
        public string engineSize { get; set; } = "7.5 Liter";
        public int SeatCount { get; set; } = 4;
    }
}
