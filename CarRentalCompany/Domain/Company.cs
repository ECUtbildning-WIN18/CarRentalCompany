using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Company
    {
        //public string CompanyName { get; } = "Lambda Car Rental";
        Car[] OurCars;
        

        public Company()
        {
            OurCars = new Car[] {
                new Car("Volvo", "S70", "ABC123", "Car", false, "Sedan"),
                new Car("Mazda", "MX5", "MAZ007", "Car", false, "Convertible"),
                new Car("Ford", "T", "TFO333", "Car", false, "MPV"),
                new Car("Tesla", "3", "ELE999", "Car", false, "Sedan")
            };
        }

        public void PrintOurCars()
        {
            foreach (Car car in OurCars)
            {
                Console.WriteLine("Brand: " + car.Brand);
            }
        }

    }
}

