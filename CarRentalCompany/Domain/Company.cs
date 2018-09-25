using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Company
    {
        public string CompanyName { get; } = "Lambda Car Rental";
        public Car[] Cars { get; }

        public Company()
        {
            Cars = new Car[] {

            };
        }

    }
}
