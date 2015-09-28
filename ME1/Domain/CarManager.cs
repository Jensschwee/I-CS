using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Foundation;

namespace Domain
{
    /// <summary>
    /// <author>Jens Schwee & Jacob Michelsen</author>
    /// <date>14/09/2015</date>
    /// </summary>
    public class CarManager
    {

        private List<Car> carList;
        private List<Truck> truckList;
        private CarDAL dal = new CarDAL();

        public CarManager()
        {
            List<Car> tempCars = dal.ReadCars();
            carList = tempCars ?? new List<Car>();

            List<Truck> tempTrucks = dal.ReadTrucks();
            truckList = tempTrucks ?? new List<Truck>();
        }

        public void RegisterCar(string model, double price, string color)
        {
            Car car = new Car(model,price, State.INSTOCK, color);
            carList.Add(car);
            SaveCars(carList);
            
        }

        public void RegisterCar(string model, string price, string color)
        {
            double doPrice = 0.0;
            if (double.TryParse(price, out doPrice))
            {
                RegisterCar(model, doPrice, color);
            }
            else
                throw new InvalidCastException();

        }

        public void RegisterTruckCar(string model, double price, string color)
        {
            Truck truck = new Truck(model, price, State.INSTOCK, color);
            truckList.Add(truck);
            SaveTruck(truckList);
        }

        public void RegisterTruckCar(string model, string price, string color) 
        {
            double doPrice = 0.0;
            if (double.TryParse(price, out doPrice))
            {
                RegisterTruckCar(model, doPrice, color);
            }
            else
                throw new InvalidCastException();
        }

        private void SaveCars(List<Car> cars)
        {
            dal.WriteCars(cars);
        }

        private void SaveTruck(List<Truck> trucks)
        {
            dal.WriteTrucks(trucks);
        }
    }
}
