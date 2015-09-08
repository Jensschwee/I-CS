using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.BO
{
    public class Business : Customer
    {

        public string SEno { get; set; }

        public string Fax { get; set; }

        public string ContactPerson { get; set; }
    }
}
