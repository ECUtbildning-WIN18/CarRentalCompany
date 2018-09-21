using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Customer
    {
        string Name;
        bool DrivingLicense;
        bool Income;

        
        public void CheckifEligible()
        {
            Console.Write("Please enter your full name :");
            Name = Console.ReadLine();
            Console.WriteLine("Do you have a valid Driving License ?\n1. Yes\n2. No");
            string answer = Console.ReadLine();
            int choice;
            if (int.TryParse(answer, out choice))
            {
                if (choice == 1) { DrivingLicense = true; } else if (choice == 2) { DrivingLicense = false; }
            }
            else { Console.WriteLine("You have entered wrong choice"); }
            Console.WriteLine("Please enter your Income for last year.");
            answer = Console.ReadLine();
            if (int.TryParse(answer, out choice))
            {
                if (choice >= 150000) { Income = true; } else { Income = false; }
            }
            if (DrivingLicense && Income) { Console.WriteLine("You are welcome to rent our cars!"); }
            else { Console.WriteLine("Sorry! You don't meet the requirements to rent a car "); }




        }
    }
}
