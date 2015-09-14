using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Truck : Vechile
    {
        public Truck(string model, double price, string state) : base(model, price, state)
        {
            
        }
    }
}
