using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace LINQTest
{
    // Define Currency
    public class Currency { public string Country; public string Mint; public float Course;}
    // Funiture information 
    public class Funiture
    {
        public string Name; public float Price; public Currency Mint; public string Type;

        public override string ToString()
        {
            return "Name: " + Name + " Price: " + Price;
        }

        
    }

    public static class Extention
    {
        public static double ConvertToCurrency(this Funiture funiture, Currency currency)
        {
            float index = funiture.Mint.Course/currency.Course;
            return funiture.Price * index;
        }

    }
    // Class testing different LINQ queries
    class Program
    {
        static void Main(string[] args)
        {
            Currency[] coins = new Currency[3];
            coins[0] = new Currency { Country = "DK", Mint = "dkr", Course = 100 };
            coins[1] = new Currency { Country = "USA", Mint = "$", Course = 547 };
            coins[2] = new Currency { Country = "EU", Mint = "EURO", Course = 744 };

            List<Funiture> catalog = new List<Funiture>();
            catalog.Add(new Funiture { Type = "Table", Name = "Ida", Price = 200, Mint = coins[1] });
            catalog.Add(new Funiture { Type = "Chair", Name = "Hanne", Price = 200, Mint = coins[1] });
            catalog.Add(new Funiture { Type = "Closet", Name = "Svend", Price = 3000, Mint = coins[0] });
            catalog.Add(new Funiture { Type = "Chair", Name = "Cabri", Price = 210, Mint = coins[2] });

            //List the complete catalog
            var completeCatalog = from cata in catalog
                                  select cata;

            foreach (var c in completeCatalog)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            // List all products with prices in $
            var catalogInUSD1 = from cata in catalog
                                  where cata.Mint.Country == "USA"
                                  select cata;

            foreach (var c in catalogInUSD1)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();


            // The same as 2 but using Extension method (Where())
            //Try to use anonymous method
            var catalogInUSD2 = catalog.Where(delegate(Funiture f)
            {
                return f.Mint.Mint == "$";
            });

            foreach (var c in catalogInUSD2)
            {
                Console.WriteLine(c.ToString());
            }

            //Try with Lambda expression
            var catalogInUSD = catalog.Where(c => c.Mint.Country == "USA");

            foreach (var c in catalogInUSD)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();


            //Create a price list taking the currency in account. Use join, projection and anonymous class
            var catalogPrice = from price in catalog
                join coin in coins on price.Mint.Country equals coin.Country
                select new {coin.Country, coin.Course, coin.Mint, price.Price, price.Name, price.Type};

            foreach (var c in catalogPrice)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();

            //The same but return a list of string (Name + price). The result must be IEnumerable<string>
            IEnumerable<string> namePrice = from cata in catalog
                join coin in coins on cata.Mint.Country equals coin.Country
                select cata.Name + "." + cata.Price;
            
            foreach (string c in namePrice)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();

            //To test Deferred add a new element between the LINQ statement and the foreach statement. What do you observe.

            catalog.Add(new Funiture { Type = "test", Name = "Ida", Price = 200, Mint = coins[1] });

            foreach (string c in namePrice)
            {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();

            //Seleve LINQ'en køres først når foreach'en køre.

            //Make a list of product not sold by using Except() method (The math. Venn difference)
            //First create a saleList with some (but not all) the furniture from product list
            List<Funiture> sale = new List<Funiture>();
            sale.Add(catalog[0]);
            sale.Add(catalog[1]);
            sale.Add(new Funiture { Type = "Table", Name = "Ida", Price = 200, Mint = coins[1] });
            sale.Add(new Funiture { Type = "Chair", Name = "Ida", Price = 200, Mint = coins[1] });
            sale.Add(new Funiture { Type = "Table", Name = "Ida", Price = 100, Mint = coins[1] });
            sale.Add(new Funiture { Type = "Chair", Name = "Hanne", Price = 150, Mint = coins[1] });
            sale.Add(new Funiture { Type = "Closet", Name = "Svend", Price = 400, Mint = coins[0] });
            sale.Add(new Funiture { Type = "Chair", Name = "Cabri", Price = 140, Mint = coins[2] });
            sale.Add(new Funiture { Type = "Table", Name = "Fisk", Price = 150, Mint = coins[2] });
            sale.Add(new Funiture { Type = "Table", Name = "Ida", Price = 100, Mint = coins[1] });

            //Then create a LINQ statement to list not sold products.
            var sold = catalog.Except(sale);

            foreach (var c in sold)
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine();

            //Implement a Extention method of the Funiture class. The method should return the price in specific currency

            //Calculate the sale balance in Danish kroner using a aggregation method
            double int2Dkk = catalog.Sum(p => p.ConvertToCurrency(coins[0]));
            var intdkk = (from s in catalog select s.Price * s.Mint.Course / 100).Sum();


            //Try to create a SQL grouping statement. Inspiration: https://msdn.microsoft.com/en-us/library/bb545971.aspx
            var grouping = from s in sale
                group s by new { s.Type,s.Name}
                into g
                select new {g.Key};

            foreach (var c in grouping)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

            //Try to encapsulate a LINQ statement in a private method.
            //var names = catalog.Select(GetName);

            Console.ReadLine();
            //var priceList =
            /*
            from ......
            where ......
            select .....
             * */
        }

        protected static readonly Expression<Func<Funiture,string>> GetName = c => c.Name;

    }




}


