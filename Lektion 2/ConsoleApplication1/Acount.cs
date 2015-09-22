using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Acount : IEnumerable<Transaction>
    {

        // Create a proper generic collection callled "tList" for the purpose
        private List<Transaction> tList = new List<Transaction>();

        // Create a method called Add to add a Transaction to the collection
        public void Add(Transaction t)
        {
            tList.Add(t);
        }

       // Create a method called CalcDeposit() what calculate the sum of the Acount and return result as and Transaction in danish kroners
       // Use foreach 
        public Transaction CalcDeposit()
        {
            Transaction t = new Transaction(DateTime.Now, new Currency());

            foreach (Transaction trans in tList)
            {
                float conIndex =  t.Cur.Value/trans.Cur.Value;

                t.amount += (long)(conIndex*trans.amount);
            }
            
            return t;
        }

        // Implement the IEnumeable interface
        public IEnumerator<Transaction> GetEnumerator()
        {
            foreach (Transaction transaction in tList)
            {
                yield return transaction;
            }
        }

        public override string ToString()
        {
            StringBuilder list = new StringBuilder();
            foreach (Transaction t in tList)
                list.Append(t.ToString() + "\n");
            return list.ToString();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        // Implement overload of + operator so you can add a Transaction to an Acount
        public static Acount operator +(Acount a, Transaction t)
        {
            a.Add(t);
            return a;
        }

        // Implement indexer for this class so it return a Transaction
        public Transaction this[int index]
        {
            get { return (Transaction)this.tList[index]; }
        }

        // Create a sort method using a of the List.Sort() methods
        public List<Transaction> SortTrans()
        {
            tList.Sort();
            //tList.Sort(delegate (Transaction t, Transaction t2)
            //{
            //    return t.CompareTo(t);
            //});
            return tList;
        }

    }
}
