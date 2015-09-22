using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Acount : IEnumerable<Transaction>
    {
       
        // Create a proper generic collection callled "tList" for the purpose

        // Create a method called Add to add a Transaction to the collection

       // Create a method called CalcDeposit() what calculate the sum of the Acount and return result as and Transaction in danish kroners
       // Use foreach 

        

        public override string ToString()
        {
            StringBuilder list = new StringBuilder();
            foreach (Transaction t in tList)
                list.Append(t.ToString() + "\n");
            return list.ToString();
        }

        // Implement the IEnumeable interface

        // Implement overload of + operator so you can add a Transaction to an Acount
        
        
        // Implement indexer for this class so it return a Transaction
       
        // Create a sort method using a of the List.Sort() methods

    }
}
