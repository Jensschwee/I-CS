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
        private static string fileLocation = "~/BusinessObj.obj";

        public List<Common.Business> ReadBusiness()
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));
            System.IO.StreamReader file = new System.IO.StreamReader(fileLocation);
            List<Business> businessList = (List<Business>)reader.Deserialize(file);
            file.Close();
            return businessList;

        }

        public void WriteBusiness(List<Business> businessList)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Business));

            System.IO.FileStream file = System.IO.File.Create(fileLocation);

            writer.Serialize(file, businessList);
            file.Close();
        }
    }
}
