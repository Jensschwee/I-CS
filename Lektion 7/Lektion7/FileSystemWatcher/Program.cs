using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common;

namespace FileSystemWatcher
{
    class Program
    {

        static string FileCarLocation = Directory.GetCurrentDirectory() + "\\Car.obj";
        static List<Car> carList = null;
        static void Main(string[] args)
        {

            if (!File.Exists(FileCarLocation))
            {
                carList = new List<Car>();
                InitCars();
            }
            carList = ReadCars();

            System.IO.FileSystemWatcher fsw = new System.IO.FileSystemWatcher();
            fsw.Path = System.IO.Path.Combine(System.Environment.CurrentDirectory);
            fsw.Filter = "*.txt";
            fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            fsw.Created += new FileSystemEventHandler(OnChanged);
            fsw.EnableRaisingEvents = true;

            Console.ReadLine();

        }

        public static void InitCars()
        {
            carList.Add(new Car("Test", 1000,State.COMMISSON, "Cool"));
            WriteCars(carList);
        }

        public static void WriteCars(List<Car> CarList)
        {
            using (Stream stream = File.Open(FileCarLocation, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, CarList);
            }
        }

        public static List<Car> ReadCars()
        {
            List<Car> CarList = null;
            if (File.Exists(FileCarLocation))
            {
                using (Stream stream = File.Open(FileCarLocation, FileMode.Open))
                {
                    BinaryFormatter bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    CarList = (List<Car>)bformatter.Deserialize(stream);
                }
            }
            return CarList;

        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            //Console.WriteLine("File: {a} {1}!", e.FullPath, e.ChangeType);
            carList.AddRange(ReadNewCarFile(e.FullPath));
            WriteCars(carList);
        }

        static List<Car> ReadNewCarFile(string filePatch)
        {
            List<Car> CarList = new List<Car>();
            FileInfo fi = new FileInfo(System.IO.Path.Combine(filePatch));
            using (StreamReader st = fi.OpenText())
            {
                String[] arInput =new string[4];

                int i = 0;
                string input;
                while ((input = st.ReadLine()) != null)
                {
                    arInput[i++] = input;
                    if (i == 4)
                    {
                        i = 0;
                        CarList.Add(new Car(arInput[0], Convert.ToDouble(arInput[1]), (State)Convert.ToInt32(arInput[2]), arInput[3]));
                    }
                }
            }
            fi.Delete();
            
            return CarList;

        }


    }
}
