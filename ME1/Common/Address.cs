using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Address
    {
        private String PersonalAddress;
        private String City;
        private String PostCode;
        private String Country; // Country as an enum

        // get and setters the C# way
        public Address(string personalAddress, string city, string postCode, string country)
        {
            PersonalAddress = personalAddress;
            City = city;
            PostCode = postCode;
            Country = country;
        }
         
    }
}
