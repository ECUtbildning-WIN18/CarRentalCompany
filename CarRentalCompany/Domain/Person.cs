using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalCompany.Domain
{
    class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int SocialSecurityNumber { get; }

        public Person(string firstName, string lastName, int socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }
    }
}
