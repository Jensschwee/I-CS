using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));
                System.IO.StreamReader file = new System.IO.StreamReader(fileBusinessLocation);
                businessList = (List<Business>)reader.Deserialize(file);
                file.Close();
            }
            catch (Exception)
            {
                
            }
            
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
            List<Private> privatesList = null;
            try
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Private));
                System.IO.StreamReader file = new System.IO.StreamReader(filePrivateLocation);
                privatesList = (List<Private>)reader.Deserialize(file);
                file.Close();
            }
            catch (Exception)
            {
                
            }
            
            return privatesList;
        }

        public void WritePrivate(List<Private> privatesList)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Private));

            System.IO.FileStream file = System.IO.File.Create(filePrivateLocation);

            writer.Serialize(file, privatesList);
            file.Close();
        }
    }
}
