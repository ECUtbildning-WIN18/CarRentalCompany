using System;

namespace CarRentalCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool validInput = false;

            Console.WriteLine("\n====== MENU ======\n");
            Console.WriteLine("1. Choose Vehicle");
            Console.WriteLine("2. Rental Period");
            Console.WriteLine("3. Check Price range");
            Console.WriteLine("\n4. Exit\n");

            Console.WriteLine("Your input: ");
            string inputValue = Console.ReadLine();

            if (int.TryParse(inputValue, out choice) && choice < 5 && choice > 0)
            {
                validInput = true;
            }
            else
            {
                validInput = false;
                Console.WriteLine("There are only 4 choices.");
            }

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
            Console.ReadLine();


        }
    }
}
