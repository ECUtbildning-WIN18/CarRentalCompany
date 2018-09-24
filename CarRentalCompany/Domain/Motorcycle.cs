using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Motorcycle : Vehicle
    {
        string TypeOfMotorcycle; // Cruiser, Scooters, Chopper
        public string DriversEligibilityNeeded { get; } = "A";

        public Motorcycle(string model, string registrationNumber, string vehicleCategory, bool isRented, string typeOfMotorcycle) 
            :base(model, registrationNumber, vehicleCategory, isRented)
        {
            TypeOfMotorcycle = typeOfMotorcycle;
        }

        public override void PrintVehicleData()
        {
            Console.WriteLine($"The motorcycle is a: {TypeOfMotorcycle}");
            Console.WriteLine($"The motorcycle is of model: {Model}");
            Console.WriteLine($"The motorcycle has registration number: {RegistrationNumber}");
            Console.WriteLine($"The motorcycle is {((IsRented) ? "not avalible" : "avalible")}");
        }
    }
}
