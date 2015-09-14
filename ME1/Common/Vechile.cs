using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Vechile
    {
        public string ID { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Common.State State { get; set; }

        public Vechile(string model, double price, Common.State state)
        {
            Model = model;
            Price = price;
            State = state;
        }

    }

    public enum State
    {
        COMMISSON, SOLD,LEASED
    }
}
