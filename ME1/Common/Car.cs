﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Car : Vechile
    {
        public Car(string model, double price, string state) : base(model, price, state)
        {
            
        }

    }
}
