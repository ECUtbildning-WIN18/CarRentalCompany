using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Car : Vehicle
    {
        string TypeOfCar;  // Sedan, MPV, Convertible
        public string DriversEligibilityNeeded { get; } = "B";

        public Car(string model, string registrationNumber, string vehicleCategory, bool isRented, string typeOfCar)
            : base(model, registrationNumber, vehicleCategory, isRented)
        {
            TypeOfCar = typeOfCar;
        }

        public override void PrintVehicleData()
        {
            Console.WriteLine($"The car is a: {TypeOfCar}");
            Console.WriteLine($"The car is of model: {Model}");
            Console.WriteLine($"The car has registration number: {RegistrationNumber}");
            Console.WriteLine($"The car is {((IsRented) ? "not avalible" : "avalible")}");
        }
    }
}
