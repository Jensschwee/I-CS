using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    /// <summary>
    /// 
    /// </summary>
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
        public int CompareTo(object obj)
        {
            if (obj.GetType() == typeof(Transaction))
                return -1;

            Transaction t = (Transaction) obj;

            if (this.Equals(t))
            {
                return 0;
            }

            if (this.TDate > t.TDate)
                return -1;
            if (this.TDate < t.TDate)
                return 1;
            else
                return 0;
        }

        // Override ToString() method so it return string ex. " 678.34 USD 
        public override string ToString()
        {
            return "Amount " + Amount + " " + this.Cur.Name;
        }

        // Implement overload of + operator
        public static Transaction operator +(Transaction t, long l)
        {
            return t.Amount+=l;
        }


        // Implement overlod of - operator
        public static Transaction operator -(Transaction t, long l)
        {
            return t.Amount -= l;
        }

        // Implement overload of * operator
        public static Transaction operator *(Transaction t, long l)
        {
            return t.Amount* l;
        }

        // Implement explicit operator Transaction to int
        public static explicit operator int(Transaction r)
        {
            return (int)r.amount;
        }

        // Implement explicit operator Transaction to float
        public static explicit operator float(Transaction r)
        {
            return (float)r.amount;
        }

        // Implement implicit operator float to Transaction
        public static implicit operator Transaction (float r)
        {
            return new Transaction(DateTime.Now, new Currency(),r);
        }


    }
}
