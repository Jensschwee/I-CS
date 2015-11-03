using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace DelegateAsync
{
    public delegate void ReadHugeFile();
    public delegate int ReadHugeBigFile();

    class Program
    {
        static byte[] buffer = new byte[1000000];

        static void Main(string[] args)
        {
            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
              Thread.CurrentThread.ManagedThreadId);

            //Deletegat for intance
            ReadHugeBigFile hf = new ReadHugeBigFile(ReadABigFile);

            IAsyncResult ar = hf.BeginInvoke(null,null);

            //int test = hf.EndInvoke(ar);

            //Console.WriteLine("Number: " + test);

            // Invoke Add() in a synchronous manner.
            //AsyncCallback callBack = new AsyncCallback(ReadABigTextFile);
            ////ReadHugeFile b = new ReadHugeFile(callBack);
            ////b.BeginInvoke(new AsyncCallback(), ); //or simply b();

            //string filename = System.IO.Path.Combine(System.Environment.CurrentDirectory, "test.txt");

            //FileStream strm = new FileStream(filename,
            //    FileMode.Open, FileAccess.Read, FileShare.Read, 1024,
            //    FileOptions.Asynchronous);

            //IAsyncResult result = strm.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(ReadABigTextFile), strm);

            //callBack.BeginInvoke()
            //Change code to implement in a asynchronous way like done in 
            //Hind: b.BeginInvoke(....)


            Console.WriteLine("Doing more work in Main()!");
            Console.WriteLine("Main thread ends");
            Console.ReadLine();
        }

        static void ReadABigTextFile(IAsyncResult result)
        {
            DateTime oldTime = DateTime.Now;
            Console.WriteLine("ReadABigTextFile() invoked on thread {0}.",
              Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Start reading");
            //Implement a streaem to read a big file


            FileStream strm = (FileStream)result.AsyncState;

            // Finished, so we can call EndRead and it will return without blocking
            int numBytes = strm.EndRead(result);

            // Don't forget to close the stream
            strm.Close();

            //Thread.Sleep(10000);

            //Console.WriteLine("Read {0} Bytes", numBytes);
            //Console.WriteLine(BitConverter.ToString(buffer));

            TimeSpan ts = DateTime.Now - oldTime;
            Console.WriteLine("Time to read: " + ts);

            Console.WriteLine("End reading");
            
        }

        static int ReadABigFile()
        {
            DateTime oldTime = DateTime.Now;
            Console.WriteLine("ReadABigTextFile() invoked on thread {0}.",
              Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("Start reading");

            FileInfo fi = new FileInfo(System.IO.Path.Combine(System.Environment.CurrentDirectory, "test.txt"));
            int count = 0;
            using (StreamReader st = fi.OpenText())
            {
                while (st.ReadLine() != null)
                {
                    count++;
                }
            }

            TimeSpan ts = DateTime.Now - oldTime;
            Console.WriteLine("Time to read: " + ts);
            Thread.Sleep(10000);
            Console.WriteLine("End reading");
            return count;

        }




    }
}
