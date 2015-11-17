using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class Address
    {
        public String RoadName { get; set; }

        public String Number { get; set; }

        public Address(string roadName, string number)
        {
            RoadName = roadName;
            Number = number;
        }
    }
}