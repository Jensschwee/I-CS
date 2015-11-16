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
    public class Truck : Vechile
    {
        public Truck() { }
        public Truck(string model, double price, State state, string color) : base(model, price, state, color)
        {
            
        }
    }
}
