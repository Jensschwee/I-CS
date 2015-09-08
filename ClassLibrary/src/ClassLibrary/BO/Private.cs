using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.BO
{
    public class Private : Customer
    {
        private DateTime dayOfBofth;

        public string Sex { get; set; }

        public TimeSpan Age()
        {
            return DateTime.Now - dayOfBofth;
        }

        
    }
}
