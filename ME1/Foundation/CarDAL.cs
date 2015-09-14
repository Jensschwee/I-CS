using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Foundation
{
    public class CarDAL
    {
        private readonly static string FileCarLocation = Directory.GetCurrentDirectory() + "\\CarObj.obj";
        private readonly static string FileTruckLocation = Directory.GetCurrentDirectory() + "\\TruckObj.obj";


        public List<Car> ReadCars()
        {
            List<Car> carList = null;
            using (Stream stream = File.Open(FileCarLocation, FileMode.Open))
            {
                BinaryFormatter bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                carList = (List<Car>)bformatter.Deserialize(stream);
            }
            return carList;

        }

        public void WriteCars(List<Car> carList)
        {
            using (Stream stream = File.Open(FileCarLocation, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, carList);
            }
        }

        public List<Truck> ReadTrucks()
        {
            List<Truck> truckList = null;
            using (Stream stream = File.Open(FileTruckLocation, FileMode.Open))
            {
                BinaryFormatter bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                truckList = (List<Truck>)bformatter.Deserialize(stream);
            }
            return truckList;
        }

        public void WriteTrucks(List<Truck> truckList)
        {
            using (Stream stream = File.Open(FileTruckLocation, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, truckList);
            }
        }


    }
}
