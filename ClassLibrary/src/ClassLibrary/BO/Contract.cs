using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.BO
{
    public class Contract
    {
        public Private Private{ get; set; }

        private List<Car> cars = new List<Car>();

        public DateTime DateOfSalge { get; set; }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            cars.Remove(car);
        }

        public List<Car> Cars()
        {
            return cars;
        }
    }
}
