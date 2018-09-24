using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Truck :Vehicle
    {
        public string TypeOfTruck { get; } // Heavy Moving Truck, Light Moving Truck, Cargo Van
        public int LoadSpace { get; }
        public string DriversEligibilityNeeded { get; } = "C";      // or "CE", for Light...Truck and Cargo Van - "B"

        public Truck(string model, string registrationNumber, string vehicleCategory, bool isRented, string typeOfTruck, int loadSpace)
            : base(model, registrationNumber, vehicleCategory, isRented) 
        {
            TypeOfTruck = typeOfTruck;
            LoadSpace = loadSpace;
        }

        public override void PrintVehicleData()
        {
            Console.WriteLine($"The truck has a load space of (m3): {LoadSpace}");
            Console.WriteLine($"The truck is of model: {TypeOfTruck}");
            Console.WriteLine($"The truck has registration number: {RegistrationNumber}");
            Console.WriteLine($"The truck is {((IsRented) ? "not avalible" : "avalible")}");
        }
    }
}
