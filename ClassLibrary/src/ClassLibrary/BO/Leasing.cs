using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.BO
{
    public class Leasing
    {

        public double RentProMonth { get; set; }

        public DateTime LeasingStart { get; set; }

        public DateTime LeasingEnd { get; set; }

        public Business Business { get; set; }

        private List<Truck> trucks = new List<Truck>();

        public void AddTruck(Truck truck)
        {
            trucks.Add(truck);
        }

        public void RemoveTruck(Truck truck)
        {
            trucks.Remove(truck);
        }

        public List<Truck> Trucks()
        {
            return trucks;
        }
    }
}
