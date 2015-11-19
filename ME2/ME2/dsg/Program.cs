using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Foundation;

namespace dsg
{
    class Program
    {
        static void Main(string[] args)
        {
            Address adr = new Address("test","tesge","gsgr","gsrg");
            CreateAdd cadd = new CreateAdd();
            cadd.createAddress(adr);
        }
    }
}
