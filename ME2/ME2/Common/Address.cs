using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class Address
    {
        private int Id;
        private String PersonalAddress;
        private String City;
        private String PostCode;
        private String Country; // Country as an enum

        public Address() { }
        // get and setters the C# way
        public Address(string personalAddress, string city, string postCode, string country)
        {
            PersonalAddress = personalAddress;
            City = city;
            PostCode = postCode;
            Country = country;
        }

        [Key]
        public int Id1
        {
            get { return Id; }
            set { Id = value; }
        }

        public string PersonalAddress1
        {
            get { return PersonalAddress; }
            set { PersonalAddress = value; }
        }

        public string City1
        {
            get { return City; }
            set { City = value; }
        }

        public string PostCode1
        {
            get { return PostCode; }
            set { PostCode = value; }
        }

        public string Country1
        {
            get { return Country; }
            set { Country = value; }
        }
    }
}
