using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.BO
{
    public class Car : Vechile
    {
        public double Price { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public StateOfTheCar StateOfTheCar { get; set; }
    }

    public enum StateOfTheCar
    {
        Commission, Sold, Leased
    }
}
