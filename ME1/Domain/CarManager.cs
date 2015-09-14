using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Foundation;

namespace Domain
{
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

        public void RegisterTruckCar(string model, double price, string color)
        {
            Truck truck = new Truck(model, price, State.INSTOCK, color);
            truckList.Add(truck);
            SaveTruck(truckList);
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
