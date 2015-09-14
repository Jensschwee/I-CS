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
            List<Business> tempBusiness = dal.ReadBusiness();
            listBusinesses = tempBusiness ?? new List<Business>();

            List<Private> tempPrivates = dal.ReadPrivate();
            listPrivates = tempPrivates ?? new List<Private>();

        }

        public void RegisterBusinessCustomer(string fax, string companyName, string contractPerson, string cVR, string name, string phone, string personalAddress, string city, string postCode, string country)
        {
            Business business = new Business(fax,companyName,contractPerson,cVR,name,phone,personalAddress,city,postCode,country);
            listBusinesses.Add(business);
            SaveBusinessCustomer(listBusinesses);
        }

        public void RegisterPrivateCustomer(string age, string sex, string name, string phone, string personalAddress, string city, string postCode, string country)
        {
            Private privateObj = new Private(age, sex, name, phone, personalAddress, city, postCode, country);
            listPrivates.Add(privateObj);
            SavePrivateCustomer(listPrivates);

        }

        private void SaveBusinessCustomer(List<Business> businessObjList)
        {
            dal.WriteBusiness(businessObjList);
        }

        private void SavePrivateCustomer(List<Private> privateObjList)
        {
            dal.WritePrivate(privateObjList);
        }
    }
}
