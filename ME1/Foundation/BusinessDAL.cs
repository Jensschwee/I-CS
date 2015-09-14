using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Foundation
{
    public class CustosmerDal
    {
        private static string fileBusinessLocation = "~/BusinessObj.obj";
        private static string filePrivateLocation = "~/PrivateObj.obj";


        public List<Common.Business> ReadBusiness()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));
            System.IO.StreamReader file = new System.IO.StreamReader(fileBusinessLocation);
            List<Business> businessList = (List<Business>)reader.Deserialize(file);
            file.Close();
            return businessList;

        }

        public void WriteBusiness(List<Business> businessList)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));

            System.IO.FileStream file = System.IO.File.Create(fileBusinessLocation);

            writer.Serialize(file, businessList);
            file.Close();
        }

        public List<Private> ReadPrivate()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));
            System.IO.StreamReader file = new System.IO.StreamReader(filePrivateLocation);
            List<Private> privatesList = (List<Private>)reader.Deserialize(file);
            file.Close();
            return privatesList;
        }

        public void WritePrivate(List<Private> privatesList)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));

            System.IO.FileStream file = System.IO.File.Create(filePrivateLocation);

            writer.Serialize(file, privatesList);
            file.Close();
        }
    }
}
