using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Foundation;

namespace Domain
{
    public class CustosmerManager
    {
        
        private CustosmerDal dal = new CustosmerDal();
        private List<Business> listBusinesses;
        private List<Private> listPrivates;

        public CustosmerManager()
        {
            listBusinesses = dal.ReadBusiness();
            listPrivates = dal.ReadPrivate();
        }

        public void RegisterBusinessCustomer(string fax, string companyName, string contractPerson, string cVR, string name, string phone, string personalAddress, string city, string postCode, string country, List<Truck> truckList = null)
        {

        }

        public void RegisterPrivateCustomer()
        {

        }
    }
}
