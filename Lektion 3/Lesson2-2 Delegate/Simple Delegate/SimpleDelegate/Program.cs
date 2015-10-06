using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    // This delegate can point to any method,
    // taking two integers and returning an integer.
    public delegate int BinaryOp( int x, int y );
    public delegate int BinaryOpTest(int a);

    public class SimpleMathEventArgs : EventArgs
    {
        public readonly string msg;

        public SimpleMathEventArgs(string message)
        {
            msg = message;
        }
    }
    public delegate void TestEvent(object msg);


    #region SimpleMath class
    // This class contains methods BinaryOp will
    // point to.
    public class SimpleMath
    {
        public event TestEvent TestHandler;

        public SimpleMath()
        { }
        public int Add( int x, int y )  
        { return x + y; }
        public int Subtract( int x, int y )
        { return x - y; }
        public int SquareNumber( int a)
        { return a * a; }
        

    } 
    #endregion

    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine("***** Simple Delegate Example *****\n");

            // Create a BinaryOp delegate object that
            // "points to" SimpleMath.Add().
            SimpleMath m = new SimpleMath();

            BinaryOp b = new BinaryOp(m.Add);
            DisplayDelegateInfo(b);

            // Invoke Add() method indirectly using delegate object.
            Console.WriteLine("10 + 10 is {0}", b(10, 10));

            b = new BinaryOp(m.Subtract);
            DisplayDelegateInfo(b);
            // Invoke Add() method indirectly using delegate object.
            Console.WriteLine("10 - 10 is {0}", b(10, 10));
            
            // Compiler error! Method does not match delegate pattern!
            BinaryOpTest b2 = new BinaryOpTest(m.SquareNumber);

            DisplayDelegateInfo(b2);
            Console.WriteLine("10 * 10 is {0}", b2(10));

            SimpleMath sm = new SimpleMath();
            BinaryOp bTest = delegate(int x, int y)
            {
                return y + x;
            };

            Console.WriteLine("10 + 10 is {0}", bTest(10,10));

            bTest = (x, y) => y + x;
            Console.WriteLine("10 + 10 is {0}", bTest(10, 10));

           SimpleMath math = new SimpleMath();

            //math.TestHandler += new SimpleMath.TestEvent();

            Console.ReadLine();
        }

        public void Test(Object msg)
        {
            Console.Out.WriteLine(msg.ToString());
        }

        #region Display delegate info
        static void DisplayDelegateInfo( Delegate delObj )
        {
            // Print the names of each member in the
            // delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", d.Method);
                Console.WriteLine("Type Name: {0}", d.Target);
            }
        }
        #endregion

    }
}

