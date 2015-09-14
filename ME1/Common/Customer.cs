using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// <author>Jens Schwee & Jacob Michelsen</author>
    /// <date>14/09/2015</date>
    /// </summary>
    [Serializable]
    public class Customer
    {
        private String ID;
        private String Name;
        private String Phone;
        private Address address;

        public Customer() { }

        public Customer(string name, string phone, string personalAddress, string city, string postCode, string country)
        {
            Name = name;
            Phone = phone;
            address = new Address(personalAddress,city,postCode,country);

        }
    }
}
