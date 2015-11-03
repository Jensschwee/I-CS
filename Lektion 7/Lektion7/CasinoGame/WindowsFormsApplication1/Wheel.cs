using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Game
{
    /// <summary>
    /// Represent a wheel of a one-armed theif running for a 
    /// random time with random speed. Creates values from 1 to 9.
    /// </summary>
    class Wheel
    {
        public string Name { get{return this.Name;} }
        private int value;
        private bool WheelRunning = false;
        private Thread t;
        static int seed = 5;

        /// <summary>
        /// Current value
        /// </summary>
        public int Value
        {
            get 
            { 
                lock (this) // Thread safe
                    return this.value; 
            }
            set 
            { 
                lock (this)
                    this.value = value; 
            }
        }

        /// <summary>
        /// Constructor create a Thread to create a sequence of
        /// random numbers from 1 to 9.
        /// </summary>
        /// <param name="Name"></param>
        public Wheel(string Name)
        {

            // create a Thread
            //Worker workerObject = new Worker();
            t = new Thread(Run);
            t.Name = Name;
            t.IsBackground = true;
            seed++;
            Random v = new Random(seed);
            Value = v.Next(1,9);
            WheelRunning = true;
            // Set up the thread at background
            // Start the thread
        }

        /// <summary>
        /// Stop the thread using a proper kill method
        /// </summary>
        public void Stop()
        {
            // Add code to stop the thread using Stopped property and Abort method
           
            WheelRunning = false;
            
            t.Abort();
        }

        /// <summary>
        /// Simulate wheel run with random speed and time.
        /// Create a loop with random count down (50 - 250) 
        /// and sleep random time (20 - 39 millisec
        /// in each iteration.
        /// </summary>
        public void Run()
        {
            Random no = new Random(DateTime.Now.Millisecond + seed*5);
            Random time = new Random(DateTime.Now.Millisecond + no.Next(1000));
            int count = no.Next(50,250);
            try
            {
                while (count > 0)
                {
                    value = no.Next(1, 9);
                    Thread.Sleep(20 + time.Next(0, 19));
                    count--;
                }
                WheelRunning = false;
            }
            catch (ThreadAbortException)
            {
                // To abort Thread
            }
        }
    }
}
