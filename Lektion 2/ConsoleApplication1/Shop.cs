using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Shop<T>
    {
        private List<Currency> cur = new List<Currency>(); // Maybe better with a Dictanary
        Acount myCount = new Acount();

        static void Main(string[] args)
        {
            Shop netBuy = new Shop();
            netBuy.cur.Add(new Currency("kr", 100, "Denmark"));
            netBuy.cur.Add( new Currency("EUR", 746, "EU"));
            netBuy.cur.Add(new Currency("USD", 660, "USA"));
            netBuy.SeeDeposit();
            netBuy.Transfer(10000f, netBuy.cur[2]); 
            // Buy 10 thing with different price, number and currency
            netBuy.Buy(100.6789f, 30, netBuy.cur[0]);
            // Show you can list all buys by using a foreach loop
            
            netBuy.SeeDeposit();
            Console.Read();
            
        }

        /// <summary>
        /// Buy a number of goods
        /// </summary>
        /// <param name="price"></param>
        /// <param name="number"></param>
        /// <param name="c"></param>
        public void Buy(float price, int number, Currency c)
        {
            DateTime date = DateTime.Now;
            myCount.Add(new Transaction(date, c, -1 * price * number)); // note the minus sign
            // Try to use the the += operator instead

        }

        /// <summary>
        /// Fill up the account
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="c"></param>
        public void Transfer(float amount, Currency c)
        {
            DateTime date = DateTime.Now;
            myCount.Add(new Transaction(date, c, amount));
            // Try to use the the += operator instead

        }

        public void SeeDeposit()
        {
            Console.Out.WriteLine(myCount.calcDeposit().ToString());
        }

        public T AMethod(T input)
        {
            return input;
        }

    }
    
}
