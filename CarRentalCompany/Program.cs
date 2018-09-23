using CarRentalCompany.Domain;
using System;


namespace CarRentalCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            int choice = 0;
            bool validInput = false;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n====== MENU ======\n");
            Console.WriteLine("1. Choose Vehicle");
            Console.WriteLine("2. Rental Period");
            Console.WriteLine("3. Check Price range");
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
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.WriteLine("");
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }
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
    }
}
