using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [Serializable]
    public class Business : Customer
    {
        public String Fax { get; set; }

        private String CompanyName { get; set; }
        private String ContractPerson { get; set; }
        private List<Truck> TruckList { get; set; }

        public String CVR { get; set; }

        public Business(string fax, string companyName, string contractPerson, string cVR, string name, string phone, string personalAddress, string city, string postCode, string country, List<Truck> truckList = null) : 
            base (name,phone,personalAddress,city,postCode,country)
        {
            Fax = fax;
            CompanyName = companyName;
            ContractPerson = contractPerson;
            CVR = cVR;
            if (truckList != null)
            {
                TruckList = truckList;
            }
            else
                TruckList = new List<Truck>();
        }


    }
}
