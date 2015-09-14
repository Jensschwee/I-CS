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
    public class CustosmerDal
    {
        private readonly static string fileBusinessLocation = Directory.GetCurrentDirectory() + "\\BusinessObj.obj";
        private readonly static string filePrivateLocation = Directory.GetCurrentDirectory() + "\\PrivateObj.obj";


        public List<Common.Business> ReadBusiness()
        {
            List<Business> businessList = null;
            using (Stream stream = File.Open(fileBusinessLocation, FileMode.Open))
            {
                BinaryFormatter bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                 businessList = (List<Business>)bformatter.Deserialize(stream);
            }

            return businessList;

        }

        public void WriteBusiness(List<Business> businessList)
        {

            using (Stream stream = File.Open(fileBusinessLocation, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, businessList);
            }
        }

        public List<Private> ReadPrivate()
        {
            List<Private> privatesList = null;
            using (Stream stream = File.Open(filePrivateLocation, FileMode.Open))
            {
                BinaryFormatter bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                privatesList = (List<Private>)bformatter.Deserialize(stream);
            }

            return privatesList;
        }

        public void WritePrivate(List<Private> privatesList)
        {
            using (Stream stream = File.Open(filePrivateLocation, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, privatesList);
            }
        }
    }
}
