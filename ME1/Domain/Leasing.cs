using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Leasing
    {
        private Business business;
        private List<Truck> truckList = new List<Truck>();
        public double RentPerMonth { get; set; } // hvor meget de skal betale hver måned
        public DateTime StartRentPeriod { get; set; } // Hvornår de starter med at leje bilen
        public DateTime RentPeriodEnd { get; set; } // hvor lang tid de skal leje bilen
    }
}
