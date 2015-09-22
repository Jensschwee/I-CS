using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Transaction: IComparable
    {
        public DateTime TDate { get; set; }
        public Currency Cur { get; set; }
        public long amount; // With 2 decimals. Why not a float?

        public Transaction(DateTime d, Currency c, float amount = 0)
        {
            this.TDate = d;
            Cur = c;
            Amount = amount;
            
        }

        public float Amount
        {
            get { return ((float)amount)/100; }
            set { amount = (long)(value*100); }
        }

        // Implement IComparable means CompareTo method


        // Override ToString() method so it return string ex. " 678.34 USD 
        

        // Implement overload of + operator
        

        // Implement overlod of - operator
        


        // Implement overload of * operator
       
        
        // Implement explicit operator Transaction to int
        
    
        // Implement explicit operator Transaction to float
       
       
        // Implement implicit operator float to Transaction


        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
