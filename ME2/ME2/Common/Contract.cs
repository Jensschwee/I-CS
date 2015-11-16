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
    public class Contract
    {
        private List<Car> carListContract = new List<Car>(); // hvilken type bil som er i kontrakten
        private Private privatee; // hvilken person som har lejet bilen

        public Contract() { }

        public Contract(Private privatee, List<Car> carListContract = null)
        {
            this.privatee = privatee;
        }
    }
}
