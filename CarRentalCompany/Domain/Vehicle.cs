using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Vehicle
    {
        public string Brand { get; protected set; }
        public string Model { get; protected set; }
        public string RegistrationNumber { get; protected set; }
        public string VehicleCategory { get; }
        public bool IsRented { get; protected set; } = false;

        public Vehicle(
           string brand,
           string model,
           string registrationNumber,
           string vehicleCategory,
           bool isRented
           )
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            VehicleCategory = vehicleCategory;
            IsRented = isRented;
        }

        public virtual void PrintVehicleData()
        {
            Console.WriteLine($"Vehicle is of brand: {Brand}");
            Console.WriteLine($"Vehicle is of model: {Model}");
            Console.WriteLine($"Vehicle is of category: {VehicleCategory}");
            Console.WriteLine($"Vehicle has registration number: {RegistrationNumber}");
            Console.WriteLine($"Vehicle is {((IsRented) ? "not avalible" : "avalible")}");
        }
    }
}

