using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));
                System.IO.StreamReader file = new System.IO.StreamReader(FileCarLocation);
                carList = (List<Car>)reader.Deserialize(file);
                file.Close();
            }
            catch (Exception)
            {

            }

            return carList;

        }

        public void WriteCars(List<Car> carList)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Car));

            System.IO.FileStream file = System.IO.File.Create(FileCarLocation);

            writer.Serialize(file, carList);
            file.Close();
        }

        public List<Truck> ReadTrucks()
        {
            List<Truck> truckList = null;
            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Truck));
                System.IO.StreamReader file = new System.IO.StreamReader(FileTruckLocation);
                truckList = (List<Truck>)reader.Deserialize(file);
                file.Close();
            }
            catch (Exception)
            {

            }

            return truckList;
        }

        public void WriteTrucks(List<Truck> truckList)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Truck));

            System.IO.FileStream file = System.IO.File.Create(FileTruckLocation);

            writer.Serialize(file, truckList);
            file.Close();
        }


    }
}
