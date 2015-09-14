using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Business : Customer
    {
        public String Fax { get; set; }

        private String CompanyName;
        private String ContractPerson;
        private List<Truck> truckList = new List<Truck>();

        public String CVR { get; set; }

        public Boolean RegisterBusiness(Business b) {
            // denne metode kalder ned på foundation-laget

            return false;
            // if success return true;
        }
    }
}
