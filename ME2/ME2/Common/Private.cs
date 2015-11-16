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
    public class Private : Customer
    {
        public String Age { get; set; }
        public String Sex { get; set; }

        public Private() { }
        public Private(string age, string sex, string name, string phone, string personalAddress, string city, string postCode, string country) :
            base(name, phone, personalAddress, city, postCode, country)
        {
            Age = age;
            Sex = sex;
        }
    }
}
