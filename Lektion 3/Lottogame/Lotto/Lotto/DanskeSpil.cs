using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lotto
{
    /// <summary>
    /// Simulate Lotto game provider "Danske Spil"
    /// Replace comment with your code
    /// </summary>
    /// <author> Steffen Skov</author>
    class DanskeSpil
    {
        // define a DELEGAT so it can sende Lotto numbers to subscribes
        public delegate void LottoNumbers(int[] num);

        // Create an EVENT or a delegate instance
        public event LottoNumbers LottoNumbersEvent;

        public DanskeSpil() { }

        static void Main(string[] args)
        {
            DanskeSpil ds = new DanskeSpil();
            LottoPlayer pl = new LottoPlayer(ds);
            pl = new LottoPlayer(ds, new[] { 5, 9, 15, 22, 24, 29, 32 });
            pl = new LottoPlayer(ds, new[] { 15, 19, 20, 25, 26, 29, 30 });

            // Try to create more player with different numbers
            // When number is set remember to catch exception
            ds.Draw();
        }

        /// <summary>
        /// This method simulate drawing at DanskeSpil
        /// </summary>
        public void Draw()
        {
            Random n = new Random(DateTime.Now.Millisecond);
            int[] num = new int[7];
            for (;;)
            {
                for (int i = 0; i < 7; i++)
                    num[i] = n.Next(1, 36);

                // To increase the probability so only one of numbers will change
                Console.WriteLine(num[0] + " " + num[1] + " " + num[2] + " " + num[3] + " " + num[4] + " " + num[5] + "\n");
                if (LottoNumbersEvent != null)
                {
                    LottoNumbersEvent(num);
                    //LottoNumbersEvent(new[] { 5, 9, 15, 22, 24, 29, 32 });
                }
                Thread.Sleep(6000);
                // FIRE the event
            }
        }
    }

}