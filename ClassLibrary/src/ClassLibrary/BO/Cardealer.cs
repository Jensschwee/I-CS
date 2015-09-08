using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ClassLibrary.BO;

namespace ClassLibrary.BO
{
    public class Cardealer
    {
        private List<Customer> customers = new List<Customer>();
        private List<Vechile> vechiles = new List<Vechile>();

        public Cardealer()
        {
        }

        public void AddCustomers(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddVechile(Vechile vechile)
        {
            vechiles.Add(vechile);
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void RemoveVechile(Vechile vechile)
        {
            vechiles.Remove(vechile);
        }


    }


}
