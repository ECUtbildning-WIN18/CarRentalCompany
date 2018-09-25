using CarRentalCompany.Domain;
using System;


namespace CarRentalCompany
{

    public enum VehicleCategory { car, Motorcycle, Truck };

    class Program
    {

        static void Main(string[] args)
        {
            GetMainMenu();

            Customer customer = new Customer();

            customer.CheckifEligible();

            Console.ReadLine();

            //Vehicle myVehicle = new Vehicle("Tesla", "ABC123", "Car", true);
            //myVehicle.PrintVehicleData();
            //Car myCar = new Car("Volvo", "LOL321", "Car", false, "Sedan");
            //myCar.PrintVehicleData();
            //Motorcycle myMotorcyle = new Motorcycle("Honda", "WOW321", "Motorcycle", false, "Cruiser");
            //myMotorcyle.PrintVehicleData();
            //Truck myTruck = new Truck("Mercedes-Benz Vito", "OPS111", "Truck", false, "Cargo Van", 6);
            //myTruck.PrintVehicleData();

            //Console.ReadLine();
        }


        public static void GetMainMenu()
        {
            Console.Clear();
            int choice = 0;
            bool validInput;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====== MENU ======\n");
            Console.WriteLine("1. Cars");
            Console.WriteLine("2. Trucks");
            Console.WriteLine("3. Motorcycles");
            Console.WriteLine("\n4. Exit\n");

            Console.WriteLine("Your input: ");

            do
            {
                Console.ResetColor();
                string inputValue = Console.ReadLine();
                if (int.TryParse(inputValue, out choice) && choice < 5 && choice > 0)
                {
                    validInput = true;
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    validInput = false;
                    Console.WriteLine("There are only 4 choices.");
                }
            } while (true);
            switch (choice)
            {
                case 1:
                    Console.WriteLine(""); //Put the Method for printing the car array here.
                    break;

                case 2:
                    Console.WriteLine("Will be added in the future.");
                    break;

                case 3:
                    Console.WriteLine("Will be added in the future.");
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
